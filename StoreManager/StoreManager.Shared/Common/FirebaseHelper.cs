using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using StoreManager.Model;

namespace StoreManager.Common
{
    class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://storemanager-c1e1d-default-rtdb.firebaseio.com/");
        public async Task<List<TimeSelection>> GetAllSelectedTime()
        {

            return (await firebase
              .Child("Sanitization")
              .OnceAsync<TimeSelection>()).Select(item => new TimeSelection
              {
                  QuestionName = item.Object.QuestionName,
                  SelectedTime = item.Object.SelectedTime
              }).ToList();
        }
        public async Task AddSelectedTime(string questionName, string selectedTime)
        {

            await firebase
              .Child("Sanitization")
              .PostAsync(new TimeSelection() { QuestionName = questionName, SelectedTime = selectedTime });
        }

        public async Task<TimeSelection> GetSelectedTime(string questionName, string selectedTime)
        {
            var allSelectedTime = await GetAllSelectedTime();
            await firebase
              .Child("Sanitization")
              .OnceAsync<TimeSelection>();
            return allSelectedTime.Where(a => (a.SelectedTime == selectedTime && a.QuestionName == questionName)).FirstOrDefault();
        }
    }
}
