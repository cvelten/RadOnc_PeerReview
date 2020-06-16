using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PeerReview
{
	public struct PatientMRN : IComparable<PatientMRN>
	{
		public readonly int mrn;
		public const int ndigits = 8;

		public PatientMRN(int mrn)
		{
			this.mrn = mrn;
		}

		public PatientMRN(string mrn)
		{
			if (!int.TryParse(mrn, out this.mrn)) this.mrn = 0;
		}

		public static bool operator ==(PatientMRN lhs, PatientMRN rhs) => lhs.mrn == rhs.mrn;
		public static bool operator !=(PatientMRN lhs, PatientMRN rhs) => lhs.mrn != rhs.mrn;
		public static bool operator <(PatientMRN lhs, PatientMRN rhs) => lhs.mrn < rhs.mrn;
		public static bool operator >(PatientMRN lhs, PatientMRN rhs) => lhs.mrn > rhs.mrn;

		public override bool Equals(object obj)
		{
			if (!(obj is PatientMRN)) return false;
			return mrn == ((PatientMRN)obj).mrn;
		}

		public override int GetHashCode() => -1815010064 + mrn.GetHashCode();

		public int CompareTo(PatientMRN other)
		{
			if (this.mrn < other.mrn) return -1;
			if (this.mrn == other.mrn) return 0;
			return 1;
		}

		public override string ToString()
		{
			return string.Format("{0:D" + ndigits + "}", mrn);
		}
	}

	public class ReviewPatientFields : IComparable<ReviewPatientFields>
	{
		public ReviewPatientFields()
		{
			Guid = Guid.NewGuid();
		}

		public ReviewPatientFields(string name, DateTime dob, PatientMRN mrn, string md, string diagnosis) : this()
		{
			Name = name;
			DOB = dob;
			MRN = mrn;
			MD = md;
			Diagnosis = diagnosis;
		}

		public string Name { get; }
		public DateTime DOB { get; }
		public PatientMRN MRN { get; }
		public string MD { get; }
		public string Diagnosis { get; }
		public Guid Guid { get; }

		public int CompareTo(ReviewPatientFields other)
		{
			return Guid.CompareTo(other.Guid);
		}

		public static ReviewPatientFields Parse(string val)
		{
			if (val.Length == 0) throw new ArgumentNullException("The provided value string is empty!");

			var rx = new Regex(@"MD:\s*(?<md>.+?)\s*Institution.+Diagnosis:\s*(?<diagnosis>\S*).+Patient:\s*(?<name>\S+).+DOB:\s*(?<dob>\S+).+MRN:\s*(?<mrn>\d*)");

			var match = rx.Match(val);
			if (!match.Success) return null;

			var name = StripDownName(match.Groups["name"].Value);
			DateTime.TryParse(match.Groups["dob"].Value, out DateTime dob);
			var mrn = new PatientMRN(match.Groups["mrn"].Value);
			var md = StripDownName(match.Groups["md"].Value);
			var diag = StripDownName(match.Groups["diagnosis"].Value);

			return new ReviewPatientFields(name, dob, mrn, md, diag);
		}

		public static bool TryParse(string val, out ReviewPatientFields fields)
		{
			fields = Parse(val);
			return !(fields is null);
		}

		private static string StripDownName(string s)
		{
			string[] remove = { "MD", "DR" };
			string[] removeLeading = { ",", ".", ";", ":" };

			s = s.ToUpper();

			foreach (var tmp in remove)
			{
				s = s.Replace(tmp, "");
			}

			foreach (var tmp in removeLeading)
			{
				while (s.StartsWith(tmp)) s = s.Substring(1);
			}

			return s.Trim();
		}
	}

	public class ReviewPatient : IComparable<ReviewPatient>
	{
		public ReviewPatient(FileInfo file) :
			this(ReviewPatientFields.Parse(PDFReader.Instance.Pdf2Txt(file)), file)
		{
		}
		public ReviewPatient(ReviewPatientFields fields, FileInfo file)
		{
			IsNull = fields is null;

			Fields = fields;

			FilePDF = file;
			FileRadialogica = new FileInfo(file?.FullName.Substring(0, file.FullName.Length - 3) + "fulpkg");
			if (!FileRadialogica.Exists && !(Fields is null) && (file?.Directory != null))
				FileRadialogica = new FileInfo(Path.Combine(file?.Directory.FullName, $"{Fields.Name}.fulpkg"));
		}

		public bool IsNull { get; }
		public string Name => Fields.Name;
		public DateTime DOB => Fields.DOB;
		public PatientMRN MRN => Fields.MRN;
		public string MD => Fields.MD;
		public string Diagnosis => Fields.Diagnosis;
		public Guid Guid => Fields.Guid;

		public ReviewPatientFields Fields { get; }
		public FileInfo FilePDF { get; }
		public FileInfo FileRadialogica { get; }


		public override string ToString()
		{
			return $"{Name} ({MRN}), {Diagnosis}, {MD}";
		}

		public static ReviewPatient Parse(FileInfo file)
		{
			if (!file.Exists) throw new ArgumentNullException("The file does not exist!");
			return new ReviewPatient(ReviewPatientFields.Parse(PDFReader.Instance.Pdf2Txt(file)), file);
		}

		public static async Task<ReviewPatient> ParseAsync(FileInfo file)
		{
			if (!file.Exists) throw new ArgumentNullException("The file does not exist!");
			return new ReviewPatient(ReviewPatientFields.Parse(await PDFReader.Instance.Pdf2TxtAsync(file)), file);
		}

		public static bool TryParse(FileInfo file, out ReviewPatient reviewPatient)
		{
			if (ReviewPatientFields.TryParse(PDFReader.Instance.Pdf2Txt(file), out var fields))
			{
				reviewPatient = new ReviewPatient(fields, file);
				return true;
			}
			else
			{
				reviewPatient = null;
				return false;
			}
		}

		public int CompareTo(ReviewPatient other)
		{
			return this.Fields.CompareTo(other.Fields);
		}
	}
}
