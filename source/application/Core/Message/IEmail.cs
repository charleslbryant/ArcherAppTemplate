namespace Archer.Core.Message
{
	using System;

	public interface IEmail
	{
		void Send(Message message, MailServer server);
	}
}