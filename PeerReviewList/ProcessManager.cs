using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReview
{
	class ProcessManager : IEnumerable<ProcessManager>, ICollection<ReviewProcess>
	{
		public const byte MaxRadialogicaProcs = 3;
		public byte MaxProcesses { get; set; }

		//public List<ReviewProcess> Processes { get; }
		//List<Processes> runningProcesses;
		public List<ReviewProcess> ProcessQueue { get; set; }
		public List<ReviewProcess> RunningProcesses { get; private set; }

		public int Count => ((ICollection<ReviewProcess>)ProcessQueue).Count;
		public bool IsReadOnly => ((ICollection<ReviewProcess>)ProcessQueue).IsReadOnly;

		public ProcessManager()
		{
			MaxProcesses = MaxRadialogicaProcs;
			ProcessQueue = new List<ReviewProcess>();
			RunningProcesses = new List<ReviewProcess>();
		}

		public ProcessManager(byte maxProcesses) : this()
		{
			if (maxProcesses > 0)
				MaxProcesses = maxProcesses;
		}

		public void KillAll()
		{
			ProcessQueue.Clear();
			RunningProcesses.Clear();
		}

		public void UpdateRunningProcesses()
		{
			RunningProcesses.RemoveAll(x => x.Process.HasExited);
			
			while (RunningProcesses.Count < MaxProcesses && ProcessQueue.Count > 0)
			{
				var proc = ProcessQueue.PopFirst();
				proc.Start();
				proc.Process.WaitForExit(500);
				RunningProcesses.Add(proc);
				if (proc.ProcessType == ProcessType.Radialogica)
					System.Threading.Thread.Sleep(1000);
			}
		}

		#region IEnumerator<> Implementation
		public IEnumerator<ProcessManager> GetEnumerator()
		{
			return ((IEnumerable<ProcessManager>)ProcessQueue).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<ProcessManager>)ProcessQueue).GetEnumerator();
		}
		#endregion

		#region ICollection<> Implementation
		public void Add(ReviewProcess item)
		{
			((ICollection<ReviewProcess>)ProcessQueue).Add(item);
		}

		public void Clear()
		{
			KillAll();
			//((ICollection<ReviewProcess>)ProcessQueue).Clear();
		}

		public bool Contains(ReviewProcess item)
		{
			return ((ICollection<ReviewProcess>)ProcessQueue).Contains(item);
		}

		public void CopyTo(ReviewProcess[] array, int arrayIndex)
		{
			((ICollection<ReviewProcess>)ProcessQueue).CopyTo(array, arrayIndex);
		}

		public bool Remove(ReviewProcess item)
		{
			return ((ICollection<ReviewProcess>)ProcessQueue).Remove(item);
		}

		IEnumerator<ReviewProcess> IEnumerable<ReviewProcess>.GetEnumerator()
		{
			return ((ICollection<ReviewProcess>)ProcessQueue).GetEnumerator();
		}
		#endregion
	}
}
