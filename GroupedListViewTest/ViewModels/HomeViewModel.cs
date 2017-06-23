using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GroupedListViewTest.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;


        public HomeViewModel()
        {
            // Prepare the dummy data to display
            var questionGroupA = new QuestionGroupViewModel
            {
                Header = "Group A",
                ShortName = "A",
                RTREnable = true
            };

            for (int i = 0; i < 20; i++)
            {
                questionGroupA.Add(new QuestionViewModel { Title = "Question" + i, QuestionType = "Type Mars" });
            }

			var questionGroupB = new QuestionGroupViewModel
			{
				Header = "Group B",
				ShortName = "B",
                RTREnable = false
			};

			for (int i = 0; i < 30; i++)
			{
				questionGroupB.Add(new QuestionViewModel { Title = "Question" + i, QuestionType = "Type Sun" });
			}

			var questionGroupC = new QuestionGroupViewModel
			{
				Header = "Group C",
				ShortName = "C",
                RTREnable = true
			};

			for (int i = 0; i < 20; i++)
			{
				questionGroupC.Add(new QuestionViewModel { Title = "Question" + i, QuestionType = "Type Earth" });
			}

	        QuestionsGrouped = new ObservableCollection<QuestionGroupViewModel>
	        {
                questionGroupA,
                questionGroupB,
                questionGroupC
	        };
    }

		private ObservableCollection<QuestionGroupViewModel> _questionsGrouped;
		public ObservableCollection<QuestionGroupViewModel> QuestionsGrouped
		{
			set
			{
				if (_questionsGrouped != value)
				{
                    _questionsGrouped = new ObservableCollection<QuestionGroupViewModel>(value);
					OnPropertyChanged("QuestionsGrouped");
				}
			}
			get
			{
				return _questionsGrouped;
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
