using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Firebase.Messaging;

namespace Test390
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class FirebaseMessaging : FirebaseMessagingService
    {
        private const string Tag = "Test";

        public override void OnNewToken(string p0)
        {
            base.OnNewToken(p0);
        }

        public override async void OnMessageReceived(RemoteMessage message)
        {
            Log.Debug(Tag, "Notification received from: " + message.From);
        }
    }
}
