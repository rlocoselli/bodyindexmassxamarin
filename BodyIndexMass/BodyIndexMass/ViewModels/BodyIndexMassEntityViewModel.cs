using BodyIndexMass.Database;
using BodyIndexMass.Models;
using BodyIndexMass.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BodyIndexMass.ViewModels
{
    public class BodyIndexMassEntityViewModel : BaseViewModel
    {
        private BodyIndexMassEntity _bodyIndexMassEntity = new BodyIndexMassEntity();

        public Command SaveResult { get; }

        public BodyIndexMassEntityViewModel()
        {
            SaveResult = new Command(async () => await Save());
        }

        public async Task Save()
        {
            IBodyIndexDataService db = DependencyService.Get<IBodyIndexDataService>();
            _bodyIndexMassEntity.DateTime = DateTime.Now;

            await db.SaveBodyAsync(_bodyIndexMassEntity);
            await Application.Current.MainPage.DisplayAlert("Saved", "Save successfully", "Ok");
        }

        public DateTime DateTime
        {
            get => _bodyIndexMassEntity.DateTime;
            set {
                _bodyIndexMassEntity.DateTime = value;
            } 
        }

        public double Weight
        {
            get => _bodyIndexMassEntity.Weight;

            set
            {
                _bodyIndexMassEntity.Weight = value;
                Result = CalculateResult();
            }
        }

        public double Height
        {
            get
            {
                return _bodyIndexMassEntity.Height;
            }

            set
            {
                _bodyIndexMassEntity.Height = value;
                Result = CalculateResult();
            }
        }

        public double Result
        {
            get => _bodyIndexMassEntity.Result;
            set
            {
                _bodyIndexMassEntity.Result = value;
                OnPropertyChanged();
            }
        }

        private double CalculateResult()
        {
            double hsquared = Math.Pow((double)((Height / 100)), 2);
            if (Height > 0) return (double)(Weight / hsquared);

            return 0;
        }
    }
}
