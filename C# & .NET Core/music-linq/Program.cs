using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var artistFromMountVernon = from match in Artists
                                        where match.Hometown == "Mount Vernon"
                                        select new {match.ArtistName, match.Age};

            //Who is the youngest artist in our collection of artists?
            var youngesArtist = from match in Artists
                                orderby match.Age ascending
                                select new {match.ArtistName[0], match.Age[0]};

            //Display all artists with 'William' somewhere in their real name
            var artistNameHasWilliam = from match in Artists
                                        where match.RealName.Contains("William") 
                                        select new {match.RealName};

            //Display all groups with names less than 8 characters in length.
            List<Group> groupNameLength = Groups.Where(group => group.GroupName.Length < 8).ToList();

            //Display the 3 oldest artist from Atlanta
            string[] oldestArtistFromAtlanta = Artists.Where(artist => artist.Hometown == "Atlanta")
                                                .OrderByDescending(artist => artist.Age)
                                                .Take(3)
                                                .ToArray();
            //                                  
                                            
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            string[] membersNotFromNY = Artists.Join(
                Groups,
                (artist => artist.GroupId),
                (group => group.Id),
                (joinedArtist,joinedGroup) =>
                {
                    artist.Group = group; return artist;
                })
                .Where(artist => (artist.Hometown != "New York City" && artist.Group != null))
                .Select(artist => artist.Group.GroupName)
                .Distinct()
                .ToArray();
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            string[] groupWuTangClan = Groups.Where(group => group.GroupName == "Wu-Tang Clan").GroupJoin(
                Artists,
                group => group.Id, artist => artist.GroupId,
                (group,artists) => { group.Members = artist.ToArray(); return group;})
                .Single();

        }
    }
}
