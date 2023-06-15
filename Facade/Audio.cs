namespace Facade
{
    // 子系统：音频解码器
    public class AudioDecoder
    {
        public void Decode(string filePath)
        {
            Console.WriteLine($"解码音频文件：{filePath}");
        }
    }

    // 子系统：音量控制
    public class VolumeControl
    {
        public void AdjustVolume(int volume)
        {
            Console.WriteLine($"调整音量为：{volume}");
        }
    }

    // 子系统：播放控制
    public class PlaybackControl
    {
        public void Play()
        {
            Console.WriteLine("开始播放");
        }

        public void Pause()
        {
            Console.WriteLine("暂停播放");
        }

        public void Stop()
        {
            Console.WriteLine("停止播放");
        }
    }

    // 外观类：音频播放器外观
    public class AudioPlayerFacade
    {
        private AudioDecoder audioDecoder;
        private VolumeControl volumeControl;
        private PlaybackControl playbackControl;

        public AudioPlayerFacade()
        {
            audioDecoder = new AudioDecoder();
            volumeControl = new VolumeControl();
            playbackControl = new PlaybackControl();
        }

        public void PlayAudio(string filePath, int volume)
        {
            audioDecoder.Decode(filePath);
            volumeControl.AdjustVolume(volume);
            playbackControl.Play();
        }

        public void PauseAudio()
        {
            playbackControl.Pause();
        }

        public void StopAudio()
        {
            playbackControl.Stop();
        }
    }
}
