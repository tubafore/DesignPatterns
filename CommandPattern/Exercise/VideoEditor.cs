using System;

namespace Exercise
{
    public class VideoEditor
    {
        public float Contrast { get; set; }
        public string Text { get; set; }

        public VideoEditor()
        {

        }

        public void LoadState(VideoEditorState state)
        {
            Contrast = state.Contrast;
            Text = state.Text;
        }

        public VideoEditorState CreateState()
        {
            return new VideoEditorState { Text = Text, Contrast = Contrast };
        }

        public override string ToString()
        {
            return $"VideoEditor {{ contrast={Contrast}, text='{Text}' }}";
        }
    }
}
