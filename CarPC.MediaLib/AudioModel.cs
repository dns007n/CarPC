using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NLayer.NAudioSupport;

namespace CarPC.MediaLib
{
    public class AudioModel
    {
        internal WaveOutEvent _WaveOut;
        public AudioModel()
        {
            _WaveOut = new WaveOutEvent();

        }
        public void PlayAudio()
        {
            string fileName = "myMp3File.mp3";
            var builder = new Mp3FileReader.FrameDecompressorBuilder(wf => new Mp3FrameDecompressor(wf));
            var reader = new Mp3FileReader(fileName, builder);
            // play or process the file, e.g.:
            _WaveOut.Init(reader);
            _WaveOut.Play();
        }
    }
}
