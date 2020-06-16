using System;
using System.Diagnostics;

namespace PeerReview
{
	public enum ProcessType { Other, PDF, Radialogica };

	class ReviewProcess : IDisposable, IEquatable<ReviewProcess>
	{
		public Process Process { get; private set; }

		public ProcessType ProcessType { get; set; }

		public bool HasStarted { get; private set; }

		public Guid Guid { get; }

		public ReviewProcess()
		{
			Process = new Process();
			ProcessType = ProcessType.Other;
			HasStarted = false;
			Guid = Guid.NewGuid();
		}

		public ReviewProcess(string fileName, ProcessType processType = ProcessType.Other) : 
			this(new ProcessStartInfo(fileName), processType)
		{
		}

		public ReviewProcess(string fileName, string arguments, ProcessType processType = ProcessType.Other) :
			this(new ProcessStartInfo(fileName, arguments), processType)
		{
		}

		public ReviewProcess(ProcessStartInfo startInfo, ProcessType processType = ProcessType.Other) : this()
		{
			Process.StartInfo = startInfo;
			ProcessType = processType;
		}

		public bool Start()
		{
			HasStarted = true;
			return Process.Start();
		}

		public static ReviewProcess Start(string fileName, ProcessType processType = ProcessType.Other)
		{
			return Start(fileName, "", processType);
		}

		public static ReviewProcess Start(string fileName, string arguments, ProcessType processType = ProcessType.Other)
		{
			var proc = new ReviewProcess(fileName, arguments, processType);
			proc.Start();
			return proc;
		}

		bool IEquatable<ReviewProcess>.Equals(ReviewProcess other)
		{
			return Guid.Equals(other.Guid);
		}

		public void Dispose()
		{
			((IDisposable)Process).Dispose();
		}
	}
}