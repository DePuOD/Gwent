using PresentationModel;
using GameEntities;
using System.Diagnostics;
using System.ComponentModel;

namespace PresentationViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {

        #region ctor

        public event PropertyChangedEventHandler? PropertyChanged;

        public ViewModel() : this(null) { }

        internal ViewModel(ModelAbstract modelAbstractAPI)
        {
            ModelLayer = modelAbstractAPI == null ? ModelAbstract.CreateModel() : modelAbstractAPI;
        }

        #endregion ctor
        public void StartGame()
        {
            Player = ModelLayer.StartGame();
        }

        private Player _player;
        public Player Player { get => _player;
            set
            {
                _player = value;
                OnPropertyChanged(nameof(Player));
            }
        }

        #region private

        private ModelAbstract ModelLayer;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion private
    }
}
