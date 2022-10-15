using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternUsingObserverPattern.Classes
{
    class DialogBox
    {
        private CheckBox CheckBox = new CheckBox();
        private Button Button = new Button();
        private TextArea TextArea = new TextArea();

        public DialogBox()
        {
            CheckBox.Attach(CheckBoxChecked);
            TextArea.Attach(TextAreaChanged);
        }

        public void SimulateUserInteraction()
        {
            CheckBox.CheckItem("Article 1");
            TextArea.SetContent("");
            TextArea.SetContent("Article 2");
            Console.WriteLine("TextBox: " + TextArea.GetContent());
            Console.WriteLine("Button: " + Button.CheckIsEnabled());
        }

        public void TextAreaChanged()
        {
            var content = TextArea.GetContent();
            var isEmpty = (content == null || string.IsNullOrEmpty(content));
            Button.SetEnabled(!isEmpty);
        }

        private void CheckBoxChecked()
        {
            TextArea.SetContent(CheckBox.GetCheckedItem());
            Button.SetEnabled(true);
        }
    }
}
