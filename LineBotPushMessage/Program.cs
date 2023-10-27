using isRock.LineBot;

namespace LineBotPushMessage;

internal class Program
{
    private static readonly string _channelAccessToken = "uP2/CXN1WuhogTQWAGVopN+sCduTFO6m7lRiGL9aN3PGiOPTLw7ukc6f9lrsjuNs4xjYzWmgLQOqkIqKo2vvmEDBiXf5aoj4JHsFKr0fzktk1s0+2j74Err9DCUwEKacI8z9l1n5stzaKxkQfHgmSQdB04t89/1O/w1cDnyilFU=";
    private static readonly string _userId = "U44bf7e305c6d159178c883ed3cc381d4";

    private static readonly Bot _bot = new(_channelAccessToken);

    static void Main(string[] args)
    {
        PushTextMessage();
        //PushEmojiTextMessage();
        PushStickerMessage();
        PushImageMessage();
        PushAudioMessage();
        PushVideoMessage();
        PushLocationMessage();
    }

    static void PushTextMessage()
    {
        _bot.PushMessage(_userId, "推送文字訊息");
    }

    static void PushEmojiTextMessage()
    {
        _bot.PushMessage(_userId, "推送文字訊息");
    }

    static void PushStickerMessage()
    {
        _bot.PushMessage(_userId, 1, 3);
    }

    static void PushImageMessage()
    {
        var url = new Uri("https://corvus-nest.azurewebsites.net/images/posts/linebots/linebot0.png");
        _bot.PushMessage(_userId, url);
    }

    static void PushAudioMessage()
    {
        var imgUrl = new Uri("https://arock.blob.core.windows.net/blogdata202008/test.mp3");
        var audioMsg = new AudioMessage(imgUrl, 6000);
        _bot.PushMessage(_userId, audioMsg);
    }

    static void PushVideoMessage()
    {
        var videoUrl = new Uri("https://arock.blob.core.windows.net/blogdata202008/POC.mp4");
        var videoPreviewUrl = new Uri("https://corvus-nest.azurewebsites.net/images/posts/linebots/linebot1.png");
        var videoMsg = new VideoMessage(videoUrl, videoPreviewUrl);
        _bot.PushMessage(_userId, videoMsg);
    }

    static void PushLocationMessage()
    {
        var title = @"台北車站";
        var address = @"10041台北市中正區忠孝西路1段49號";
        var latitude = 25.0464273;
        var longitude = 121.5130522;
        var locationMsg = new LocationMessage(title, address, latitude, longitude);
        _bot.PushMessage(_userId, locationMsg);
    }
}