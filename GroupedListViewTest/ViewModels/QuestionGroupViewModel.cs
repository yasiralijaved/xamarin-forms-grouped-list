using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GroupedListViewTest.ViewModels
{
    public class QuestionGroupViewModel : ObservableCollection<QuestionViewModel>, INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		private string _header;
		public string Header
		{
			set
			{
				if (_header != value)
				{
					_header = value;
					OnPropertyChanged("Header");
				}
			}
			get
			{
				return _header;
			}
		}

		private string _shortName;
		public string ShortName
		{
			set
			{
				if (_shortName != value)
				{
					_shortName = value;
					OnPropertyChanged("ShortName");
				}
			}
			get
			{
				return _shortName;
			}
		}

        private bool _rTREnable;
		public bool RTREnable
		{
			set
			{
				if (_rTREnable != value)
				{
					_rTREnable = value;
					OnPropertyChanged("RTREnable");
				}
			}
			get
			{
				return _rTREnable;
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
