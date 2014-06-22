namespace Archer.Core.Message
{
	using System;

	public class EmailManager
	{
		private IEmail email;

		public EmailManager(IEmail email)
		{
			this.email = email;
		}

		public void Send(Message message, MailServer server)
		{
			this.email.Send(message, server);
		}
	}
}