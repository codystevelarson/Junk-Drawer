using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    public class TicketRepository
    {
        private const string FileHeader = "TicketID,FirstName,LastName,NumberPicks,Powerball";

        private string _filePath;

        public TicketRepository(string filePath)
        {
            _filePath = filePath;
        }
        
        //Initialize the text data doc. 
        public void Init()
        {
            CreateTicketFile(new List<Ticket>());
        }

        //List picks
        public List<Ticket> List()
        {
            List<Ticket> tickets = new List<Ticket>();

            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine(); //Skip the header
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Ticket newTicket = new Ticket();

                    string[] columns = line.Split(',');

                    newTicket.TicketID = int.Parse(columns[0]);
                    newTicket.FirstName = columns[1];
                    newTicket.LastName = columns[2];

                    string[] picks = columns[3].Split('.');
                    for(int i = 0; i < picks.Length - 1; i++)
                    {                        
                        newTicket.NumberPicks[i] = int.Parse(picks[i]);
                    }
                    newTicket.Powerball = int.Parse(columns[4]);

                    tickets.Add(newTicket);
                }
            }
            return tickets;        
        }

        //Add pick
        public void Add(Ticket ticket)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                ///FirstName,LastName,Major,GPA
                string line = CreateCSVForTicket(ticket);
                sw.WriteLine(line);
            }
        }

        //Create data for file
        public string CreateCSVForTicket(Ticket ticket)
        {
            return string.Format("{0},{1},{2},{3},{4}", ticket.TicketID, ticket.FirstName, ticket.LastName, ConsoleOutput.PicksToString(ticket.NumberPicks, false), ticket.Powerball.ToString());
        }

        private void CreateTicketFile(List<Ticket> tickets)
        {
            if (!File.Exists(_filePath))
            {
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    sw.WriteLine(FileHeader);                   

                    foreach (var ticket in tickets)
                    {
                        sw.WriteLine(CreateCSVForTicket(ticket));
                    }
                }
            }            
        }
       
    }
}
