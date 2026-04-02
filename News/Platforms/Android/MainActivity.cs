using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Firebase;
using Plugin.Firebase.CloudMessaging;
using System;
using Android.Content;

namespace News
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            // Try to initialize Firebase early for this Activity/process.
            try
            {
                var app = FirebaseApp.InitializeApp(this);
                if (app == null)
                {
                    Log.Warn("FirebaseInit", "FirebaseApp.InitializeApp returned null - check Platforms/Android/google-services.json and ApplicationId.");
                }
                else
                {
                    Log.Info("FirebaseInit", $"Firebase initialized: {app.Name}");
                }
            }
            catch (Exception ex)
            {
                Log.Error("FirebaseInit", ex.ToString());
            }

            base.OnCreate(savedInstanceState);
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#FFFFFF"));
            HandleIntent(Intent);
            CreateNotificationChannelIfNeeded();
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            HandleIntent(intent);
        }

        private static void HandleIntent(Intent intent)
        {
            FirebaseCloudMessagingImplementation.OnNewIntent(intent);
        }

        private void CreateNotificationChannelIfNeeded()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                CreateNotificationChannel();
            }
        }

        private void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                var channelId = $"{PackageName}.general";
                var channelName = "General Notifications";
                var channelDescription = "Notifications for general updates";
                var importance = NotificationImportance.Default;

                var notificationManager = (NotificationManager)GetSystemService(NotificationService);
                if (notificationManager != null)
                {
                    var channel = new NotificationChannel(channelId, channelName, importance)
                    {
                        Description = channelDescription
                    };
                    notificationManager.CreateNotificationChannel(channel);
                }

                // Assign the channel ID to Firebase Cloud Messaging
                FirebaseCloudMessagingImplementation.ChannelId = channelId;
            }
        }
    }
}