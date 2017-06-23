using System;
using System.ComponentModel;

namespace GroupedListViewTest.ViewModels
{
    public class QuestionViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

        private string _title;
		public string Title
		{
			set
			{
				if (_title != value)
				{
					_title = value;
					OnPropertyChanged("Title");
				}
			}
			get
			{
				return _title;
			}
		}

		private string _questionType;
		public string QuestionType
		{
			set
			{
				if (_questionType != value)
				{
					_questionType = value;
					OnPropertyChanged("QuestionType");
				}
			}
			get
			{
				return _questionType;
			}
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}

    }
}
