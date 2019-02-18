using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using AudascanReference;


namespace code.Audascan
{
	public class AudascanChannelFactory : IDisposable
	{

		private readonly X509Certificate2 _channelCertificate;
		private readonly ChannelFactory<ABZAudascanV8SoapChannel> _channelFactory;

		public AudascanChannelFactory()
		{

			var endpoint = new EndpointAddress(new Uri("https://www.abzportal.nl/isa-ws/services/isa3"));

			var binding = new BasicHttpsBinding();
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;

			var certificateName = "wrong.pfx";
			var certificatePassword = "123";

			_channelCertificate = new X509Certificate2(certificateName, certificatePassword,
				X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
			_channelFactory = new ChannelFactory<ABZAudascanV8SoapChannel>(binding, endpoint);
			_channelFactory.Credentials.ClientCertificate.Certificate = _channelCertificate;
		}

		public ABZAudascanV8SoapChannel CreateChannel()
		{
			return _channelFactory.CreateChannel();
		}

		#region IDisposable implementation

		public void Dispose()
		{
			Dispose(true);
			// Use SupressFinalize in case a subclass
			// of this type implements a finalizer.
			GC.SuppressFinalize(this);
		}

		private bool _disposed;

		private void Dispose(bool disposing)
		{
			if (_disposed)
				return;
			if (disposing)
			{


				if (_channelFactory != null)
					(_channelFactory as IDisposable).Dispose();
				if (_channelCertificate != null)
					_channelCertificate.Dispose();
			}
			_disposed = true;
		}

		#endregion
	}
}
