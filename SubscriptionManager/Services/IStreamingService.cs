namespace SubscriptionManager.Services
{
	public interface IStreamingService
	{
		bool IsCurrentlySubscribed();
		bool Subscribe();
		bool Unsubscribe();
	}
}
