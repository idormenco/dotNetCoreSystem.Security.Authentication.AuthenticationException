using System;
using System.ServiceModel;
using System.Threading.Tasks;
using AudascanReference;
using code.Audascan;

namespace code
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var audascanChannelFactory = new AudascanChannelFactory();


			var request = new geefAntwoordRequest
			{
				AbzAudascanV8 = new ABZAUDASCANV8REQUEST
				{
					VT = new ABZAUDASCANV8REQUESTVT
					{
						VT_KENTEKEN = "KENTEKEN"
					}
				}
			};

			var channel = audascanChannelFactory.CreateChannel();
			try
			{
				Console.WriteLine("start");
				await channel.geefAntwoordAsync(request);
				Console.WriteLine("end");
			}
			catch (Exception e)
			{
				Console.WriteLine("catches exception");
				throw;
			}
			finally
			{
				Console.WriteLine("finally");
				if (channel.State != CommunicationState.Faulted)
				{
					channel.Close();
				}
				else
				{
					channel.Abort();
				}

				channel.Dispose();
			}
		}
	}
}
