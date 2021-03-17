using BodyIndexMass.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BodyIndexMass.Database
{
    public class BodyIndexMassData
    {
        readonly SQLiteAsyncConnection database;

        public BodyIndexMassData()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BMI.db3");
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<BodyIndexMassEntity>().Wait();
        }

        public Task<List<BodyIndexMassEntity>> GetBodyAsync()
        {
            //Get all notes.
            return database.Table<BodyIndexMassEntity>().ToListAsync();
        }

 
        public Task<int> SaveBodyAsync(BodyIndexMassEntity body)
        {
            if (body.ID != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(body);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(body);
            }
        }

        public Task<int> DeleteNoteAsync(BodyIndexMassEntity body)
        {
            // Delete a note.
            return database.DeleteAsync(body);
        }
    }
}
