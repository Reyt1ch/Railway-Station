using RailwayStation.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RailwayStation.Service
{
    public class DataService
    {
        private DbRepository db; // Replace 'DbRepository' with your actual DbContext class name

        public DataService()
        {
            db = new DbRepository(); // Replace 'DbRepository' with your actual DbContext class name
        }

        // Destination CRUD operations

        public List<Destination> GetAllDestinations()
        {
            return db.Destinations.ToList();
        }

        public void AddDestination(Destination destination)
        {
            if (string.IsNullOrWhiteSpace(destination.name))
            {
                throw new Exception("Name cannot be null or whitespace!");
            }
            db.Destinations.Add(destination);
            db.SaveChanges();
        }

        public void UpdateDestination(Destination destination)
        {
            if (string.IsNullOrWhiteSpace(destination.name))
            {
                throw new Exception("Name cannot be null or whitespace!");
            }

            var existingDestination = db.Destinations.Find(destination.id);
            if (existingDestination != null)
            {
                existingDestination.name = destination.name; // Update the Name property

                db.Entry(existingDestination).State = EntityState.Modified;
            }
            db.SaveChanges();
        }

        public void DeleteDestination(int destinationId)
        {
            var destination = db.Destinations.Find(destinationId);
            if (destination != null)
            {
                db.Destinations.Remove(destination);
                db.SaveChanges();
            }
        }

        public Destination FindDestinationById(int id)
        {
            return db.Destinations.FirstOrDefault(d => d.id == id);
        }

        public Destination FindDestinationByName(string name)
        {
            Destination destination = db.Destinations.FirstOrDefault(d => d.name == name);

            if (destination == null)
            {
                throw new Exception ($"{name} does not exist!");
            }

            return destination;
        }

        // Race CRUD operations

        public List<Race> GetAllRaces()
        {
            return db.Races.ToList();
        }

        public void AddRace(Race race)
        {
            db.Races.Add(race);
            db.SaveChanges();
        }

        public void UpdateRace(Race race)
        {
            var existingRace = db.Races.Find(race.id);
            if (existingRace != null)
            {
                existingRace.destination = race.destination;
                existingRace.numberOfSeatsClass1 = race.numberOfSeatsClass1;
                existingRace.numberOfSeatsClass2 = race.numberOfSeatsClass2;
                existingRace.numberOfSeatsClass3 = race.numberOfSeatsClass3;
                existingRace.priceClass1 = race.priceClass1;
                existingRace.priceClass2 = race.priceClass2;
                existingRace.priceClass3 = race.priceClass3;

                db.Entry(existingRace).State = EntityState.Modified;
            }
            db.SaveChanges();
        }

        public void DeleteRace(int raceId)
        {
            var race = db.Races.Find(raceId);
            if (race != null)
            {
                db.Races.Remove(race);
                db.SaveChanges();
            }
        }

        public Race FindRaceById(int id)
        {
            return db.Races.FirstOrDefault(r => r.id == id);
        }

        // Day CRUD operations

        public List<Day> GetAllDays()
        {
            return db.Days.ToList();
        }

        public Day FindDayByCode(string code)
        {
            return db.Days.FirstOrDefault(d => d.code.Equals(code));
        }

        // Timetable CRUD operations

        public List<Timetable> GetAllTimetables()
        {
            return db.Timetables.ToList();
        }

        public void AddTimetable(Timetable timetable)
        {
            db.Timetables.Add(timetable);
            db.SaveChanges();
        }

        public void UpdateTimetable(Timetable timetable)
        {
            var existingTimetable = db.Timetables.Find(timetable.id);
            if (existingTimetable != null)
            {
                existingTimetable.race = timetable.race;
                existingTimetable.arrivalDay = timetable.arrivalDay;
                existingTimetable.arrivalTime = timetable.arrivalTime;
                existingTimetable.departingDay= timetable.departingDay;
                existingTimetable.departingTime = timetable.departingTime;

                db.Entry(existingTimetable).State = EntityState.Modified;
            }
            db.SaveChanges();
        }

        public void DeleteTimetable(int timetableId)
        {
            var timetable = db.Timetables.Find(timetableId);
            if (timetable != null)
            {
                db.Timetables.Remove(timetable);
                db.SaveChanges();
            }
        }

        // Class CRUD operations

        public List<Class> GetAllClasses()
        {
            return db.Classes.ToList();
        }

        // Reservation CRUD operations

        public List<Reservation> GetAllReservations()
        {
            return db.Reservations.Include(r => r.timetable)
                .Include(r => r.Class1)
                .ToList();
        }

        public void AddReservation(Reservation reservation)
        {
            db.Reservations.Add(reservation);
            db.SaveChanges();
        }

        public void UpdateReservation(Reservation reservation)
        {
            db.Entry(reservation).State = EntityState.Modified;
            db.SaveChanges();
        }

        // CancelledRace CRUD operations

        public List<CancelledRace> GetAllCancelledRaces()
        {
            return db.CancelledRaces.Include(c => c.timetable).ToList();
        }

        public void AddCancelledRace(CancelledRace cancelledRace)
        {
            db.CancelledRaces.Add(cancelledRace);
            db.SaveChanges();
        }

        public void UpdateCancelledRace(CancelledRace cancelledRace)
        {
            db.Entry(cancelledRace).State = EntityState.Modified;
            db.SaveChanges();
        }

        // Dispose of the DbContext when you're done using it

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
