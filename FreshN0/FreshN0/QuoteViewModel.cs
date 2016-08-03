using System.ComponentModel;
using System.Runtime.CompilerServices;
using FreshN0.Annotations;
using Xamarin.Forms;

namespace FreshN0
{
    public class QuoteViewModel : INotifyPropertyChanged
    {
        private string _quoteName;

        public string QuoteName
        {
            get { return _quoteName; }

            set
            {
                _quoteName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(QuoteName)));
            }
        }

        public Command ResetQuoteName
        {
            get
            {
                return new Command(() =>
                {
                    this.QuoteName = "First Value";
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public QuoteViewModel()
        {
            this.QuoteName = "First Value";
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}