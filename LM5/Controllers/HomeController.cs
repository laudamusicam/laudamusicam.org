using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

using LaudaMusicam.Models;

namespace LaudaMusicam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var address_StBarts = new Address { Name = "St. Bartholomew's Episcopal Church", StreetAddressLine1 = "1790 Lavista Road", City = "Atlanta", StateProvince = "GA", ZipCode = "30329" };
            var address_EpiscopalChurchOfTheGoodShepherd = new Address { Name = "Episcopal Church of the Good Shepherd", StreetAddressLine1 = "4140 Clark Street SW", City = "Covington", StateProvince = "GA", ZipCode = "30014" };
            var address_ChurchOfTheNewCovenant = new Address { Name = "Church of the New Covenant", StreetAddressLine1 = "3330 Chestnut Drive", City = "Doraville", StateProvince = "GA", ZipCode = "30340" };
            var address_WoodruffArtsCenter = new Address { Name = "Woodruff Arts Center", StreetAddressLine1 = "1280 Peachtree Street NE", City = "Atlanta", StateProvince = "GA", ZipCode = "30309" };
            var address_KelischeksWorkshop = new Address { Name = "Kelischek Workshop for Historical Instruments", StreetAddressLine1 = "199 Waldroup Road", City = "Brasstown", StateProvince = "NC", ZipCode = "28902" };
            var address_JasperEpiscopalChurch = new Address { Name = "Episcopal Church - Holy Family", StreetAddressLine1 = "202 Griffith Rd", City = "Jasper", StateProvince = "GA", ZipCode = "30143" };
            var address_StLukeLutheranChurch = new Address { Name = "St. Luke Lutheran Church", StreetAddressLine1 = "3264 Northside Parkway NW", City = "Atlanta", StateProvince = "GA", ZipCode = "30327" };
            var address_MorningsidePresbyterian = new Address { Name = "Morningside Presbyterian Church", StreetAddressLine1 = "1411 N Morningside Dr NE", City = "Atlanta", StateProvince = "GA", ZipCode = "30306" };
            var address_AtlantaSpeechSchool = new Address { Name = "Atlanta Speech School", StreetAddressLine1 = "3160 Northside Parkway NW", City = "Atlanta", StateProvince = "GA", ZipCode = "30327" };

            var events = new List<EventModel>();

            //events.Add(new EventModel()
            //{
            //    Id = 1,
            //    Name = "Music in the Italian Renaissance",
            //    Description = "Lauda Musicam gives the audience a sample of music in Italy from the 13th through 17th centuries in its concert at St. Bartholomew's Episcopal Church, 1790 LaVista Road, Atlanta, GA 30329.  Admission is free, but donations are suggested.  Uncommon Practice, a 16-member vocal ensemble directed by Robert Bolyard, will assist.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2010-11-19 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time"))
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 2,
            //    Name = "Atlanta Recorder Society's Consort Day",
            //    Description = "Participation in the Atlanta Recorder Society's Consort Day performance at Unitarian Universalist Congreation of Atlanta, 1911 Cliff Valley Way, Atlanta, GA 30329.  Visit http://home.mindspring.com/~gillmorm/ for more information.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2011-03-27 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time"))
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 2,
            //    Name = "Jewish Influence in Early Music.",
            //    Description = "Sephardic and Jewish music will demonstrate many of the artistic contributions of the European Jewish culture in the concert at St. Bartholomew's Episcopal Church, 1790 LaVista Road, Atlanta, GA 30329.  Admission is free, but donations are suggested.  Uncommon Practice, a 16-member vocal ensemble directed by Robert Bolyard, will assist.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2011-05-20 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time"))
            //});

            //            events.Add(new EventModel()
            //            {
            //                Id = 1,
            //                Name = "War and Eternal Peace.",
            //                Description = @"Lauda Musicam of Atlanta, 
            //conducted by Jody Miller, performs Medieval and 
            //Renaissance music on instruments appropriate for the time period.  
            //Battaglias, or war tunes, are the focal point of this Veteran's Day 
            //concert, but music of peace and eternal peace will be included as a 
            //remembrance to all involved in conflict throughout the ages.  Lauda 
            //Musicam of Atlanta is a 50-member instrumental ensemble of recorders, 
            //viols, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, and 
            //percussion.  Uncommon Practice, an a cappella vocal ensemble 
            //specializing in music before Bach's ""common practice"" period, will 
            //assist.  St. Bartholomew's Episcopal Church, 1790 Lavista Road, 
            //Atlanta, GA 30329.  404-634-3336 or www.laudamusicam.org. The concert 
            //is free, but donations are accepted and appreciated.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2011-11-11 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time"))
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 2,
            //                Name = "A Valentine's Day Celebration:  Love Music of the Renaissance.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, performs Medieval and Renaissance music on instruments appropriate for the time period.
            //In keeping with the Valentine's Day theme, the musicians will perform music depicting the popular theme of love.
            //Lauda Musicam of Atlanta is a 50-member instrumental ensemble of recorders, viols, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, and percussion.
            //Uncommon Practice, an a cappella vocal ensemble specializing in music before Bach's ""common practice"" period, will assist.
            //Holy Trinity Parish, 515 East Ponce de Leon Avenue, Decatur, GA 30030. 404-377-2622 or www.laudamusicam.org.
            //The concert is free, but donations are accepted and appreciated.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2012-02-11 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time"))
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 3,
            //                Name = "Family and Children's Concert",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, will perform 
            //standard fare from the Medieval, Renaissance, and Baroque periods on 
            //instruments appropriate for the time period. Music by some of the most 
            //well-known composers will make this concert fun for the newbie and the 
            //enthusiast alike! Built into the performance will be demonstrations of 
            //the instruments and music forms for people less familiar with 
            //historical music. Members will lead a ""petting zoo"" after the concert 
            //for people to see and try instruments and to ask members questions. 
            //Lauda Musicam of Atlanta is a 50-member instrumental ensemble of 
            //recorders, viols, harpsichord, sackbuts, shawms, harps, crumhorns, 
            //cornettos, and percussion. Uncommon Practice, an a cappella vocal 
            //ensemble specializing in music before Bach's ""common practice"" period, 
            //will assist. The Episcopal Church of the Good Shepherd, 4140 Clark 
            //Street SW, Covington, GA 30014. 770-786-3278 or www.laudamusicam.org. 
            //The concert is free, but donations are accepted and appreciated.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2012-05-06 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time"))
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 4,
            //                Name = "Family and Children's Concert.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, will perform 
            //standard fare from the Medieval, Renaissance, and Baroque periods on 
            //instruments appropriate for the time period.  Music by some of the most 
            //well-known composers will make this concert fun for the newbie and the 
            //enthusiast alike!  Built into the performance will be demonstrations of 
            //the instruments and music forms for people less familiar with 
            //historical music.  Members will lead a ""petting zoo"" after the concert 
            //for people to see and try instruments and to ask members questions.  
            //Lauda Musicam of Atlanta is a 50-member instrumental ensemble of 
            //recorders, viols, harpsichord, sackbuts, shawms, harps, crumhorns, 
            //cornettos, and percussion.  Uncommon Practice, an a cappella vocal 
            //ensemble specializing in music before Bach's ""common practice"" period, 
            //will assist.  St. Bartholomew's Episcopal Church, 1790 Lavista Road, 
            //Atlanta, GA 30329.  404-634-3336 or www.laudamusicam.org.  The concert 
            //is free, but donations are accepted and appreciated.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2012-05-18 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time"))
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 5,
            //                Name = "Cancioneiro de Palacio:  Music of Renaissance Spain.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, presents ""Cancioneiro de Palacio:  Music of Renaissance Spain.""
            //Music from the large songbook Cancioneiro de Palacio, compiled over 40 years during the reign of the Catholic Monarchs, serves as the backbone of this concert of Spanish music.
            //Lauda Musicam performs on wind, string, and percussion instruments in popular use during the time period.  The vocal ensemble Uncommon Practice assists in this performance.
            //Lauda Musicam is an ensemble of historical instruments, including recorder, viol, cornetto, harp, sackbut, shawm, percussion, and voice.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2012-11-09 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_StBarts,
            //                Comment1 = "Free, but donations are accepted."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 6,
            //                Name = "Love Music of the Renaissance:  A Valentine's Day Concert.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, presents ""Love Music of the Renaissance:  A Valentine's Day Concert.""
            //Often the subject of music throughout history, love with all of its joy and pain is celebrated in a concert of music for the occasion.
            //Lauda Musicam performs on wind, string, and percussion instruments in popular use during the time period.
            //Lauda Musicam is an ensemble of historical instruments, including recorder, viol, cornetto, harp, sackbut, shawm, percussion, and voice.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2013-02-10 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_EpiscopalChurchOfTheGoodShepherd,
            //                Comment1 = "Free, but donations are accepted."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 7,
            //                Name = "Fun and Games:  A Family and Children's Concert.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, presents ""Fun and Games: A Family and Children's Concert.""
            //Playful, mischievous, and fun music as various instruments used during the renaissance period are demonstrated.
            //The concert will be followed by an instrument ""petting zoo"" where the audience can see and play the instruments themselves!
            //Lauda Musicam performs on wind, string, and percussion instruments in popular use during the time period.  The vocal ensemble Uncommon Practice assists in this performance.
            //Lauda Musicam is an ensemble of historical instruments, including recorder, viol, cornetto, harp, sackbut, shawm, percussion, and voice.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2013-05-10 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_StBarts,
            //                Comment1 = "Free, but donations are accepted."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 8,
            //                Name = "Da Capo: Lauda Musicam Celebrates Its Fifth Year.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, performs Medieval and Renaissance music on instruments appropriate for the time period.
            //Lauda's yearlong observance of its fifth year begins with this concert of our greatest hits.
            //This sampling of music from previous concerts reminds us of the wealth of compositions left by Renaissance-era composers.
            //Lauda Musicam of Atlanta is an instrumental ensemble of recorders, viols, flutes, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, and percussion.
            //Uncommon Practice, an a cappella vocal ensemble specializing in music before Bach's ""common practice"" period, will assist.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2013-11-15 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_StBarts,
            //                Comment1 = "The concert is free, but donations are accepted and appreciated."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 9,
            //                Name = "Bring on the Spring: A French & English Celebration of Springtime.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, performs Medieval and Renaissance music on instruments appropriate for the time period.
            //After the dreary winter months, the coming of spring warrants a celebration.
            //Lauda performs some of the music written for this joyous annual change in seasons.
            //Lauda Musicam of Atlanta is an instrumental ensemble of recorders, viols, flutes, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, and percussion.
            //Uncommon Practice, an a cappella vocal ensemble specializing in music before Bach's ""common practice"" period, will assist.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2014-02-23 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_ChurchOfTheNewCovenant,
            //                Comment1 = "The concert is free, but donations are accepted and appreciated."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 10,
            //                Name = "Instruments of the Renaissance: A Family & Children's Concert.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, will perform standard fare from the Medieval, Renaissance, and Baroque periods on instruments appropriate for the time period.
            //The debut of a consort of handmade Boaz Berney Renaissance flutes will be the climax of our fifth season.
            //Built into the performance will be demonstrations of the instruments and music forms for people less familiar with historical music.
            //Members will lead a ""petting zoo"" after the concert for people to see and try instruments and to ask members questions.
            //Lauda Musicam of Atlanta is an instrumental ensemble of recorders, viols, flutes, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, and percussion.
            //Uncommon Practice, an a cappella vocal ensemble specializing in music before Bach's ""common practice"" period, will assist.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2014-05-04 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_StBarts,
            //                Comment1 = "The concert is free, but donations are accepted and appreciated."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 11,
            //                Name = "The Beauty of Brass: Italian Renaissance Music from Florence.",
            //                Description = @"This performance will celebrate an exhibit of marble panels created by Italian sculptor Luca della Robbia for the Florence Cathedral’s Cantoria in the 1430s.
            //Lauda Musicam’s brass quartet will perform Italian music that could have been heard in the cathedral for the two centuries following the installation of these panels.
            //This quartet performs on sackbuts (Renaissance trombones), a tenor cornetto (a curved wooden instrument, with a trumpet-like mouthpiece, also known as a Lyzard), and a dulcian (a Renaissance bassoon).
            //We hope that you will be able to join us for an evening of Italian Renaissance music.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2014-11-07 19:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_WoodruffArtsCenter
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 12,
            //                Name = "Renaissance Music by The Carolyn Consort.",
            //                Description = @"This performance will celebrate an exhibit of marble panels created by Italian sculptor Luca della Robbia for the Florence Cathedral’s Cantoria in the 1430s.
            //The Carolyn consort is a quartet of musicians who perform Early Music of the Baroque, Renaissance and Medieval periods.
            //The music is played on replicas of instruments that were in common use before 1750.
            //The ensemble uses mostly recorders of all sizes, but may include capped reeds, percussion and other instruments of the period.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2014-11-08 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_WoodruffArtsCenter
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 13,
            //                Name = "The Splendor of the Cathedral: Italian Renaissance Music from Florence.",
            //                Description = @"Italian sculptor Luca della Robbia produced a set of marble panels for the Florence Cathedral’s cantoria in the 1430s.
            //Lauda Musicam of Atlanta will perform Italian music that could have been heard in the cathedral for the two centuries following the installation of these panels.
            //Recorders, viols, sackbuts, cornettos, flutes, shawms, and voices would have undoubtedly been used in these performances.
            //Along with Uncommon Practice, an a cappella vocal ensemble, Lauda Musicam will recreate a musical performance to help Woodruff Arts Center celebrate the arrival of Robbia’s work.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2014-11-09 14:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_WoodruffArtsCenter,
            //                Comment1 = "Full group perform at Woodruff Arts Center in atrium at 2 PM. Small groups perform in the gallery at 3 PM."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 14,
            //                Name = "The Splendor of the Cathedral: Italian Renaissance Music from Florence.",
            //                Description = @"Italian  sculptor Luca della Robbia produced a set of marble panels for the Florence Cathedral’s cantoria in the 1430s.
            //Lauda Musicam of Atlanta will perform Italian music that could have been heard in the cathedral for the two centuries following the installation of these panels.
            //Recorders, viols, sackbuts, cornettos, flutes, shawms, and voices would have undoubtedly been used in these performances.
            //Along with Uncommon Practice, an a cappella vocal ensemble, Lauda Musicam will recreate a musical performance to help Woodruff Arts Center celebrate the arrival of Robbia’s work.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2014-11-14 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_StBarts,
            //                Comment1 = "The concert is free, but donations are accepted and appreciated."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 15,
            //                Name = "Celebrations: Early Music for Special Occasions.",
            //                Description = @"Whether a birthday, a coronation, or a feast, music often played an important role in life’s celebrations.
            //Lauda Musicam of Atlanta will perform renaissance and baroque intradas, fanfares, and other celebratory music as part of the Concert with a Cause concert series at the Church of the New Covenant.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2015-02-22 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_ChurchOfTheNewCovenant,
            //                Comment1 = "Donations are accepted for a charity of the church’s choice."
            //            });

            //            events.Add(new EventModel()
            //            {
            //                Id = 16,
            //                Name = "Instruments of the Renaissance: A Family and Children's Concert.",
            //                Description = @"Lauda Musicam of Atlanta, conducted by Jody Miller, will perform repertoire from the Medieval, Renaissance, and Baroque periods
            //on instruments appropriate for the time period.
            //Built into the performance will be demonstrations of the instruments and music forms for people less familiar with historical music.
            //Members will lead a ""petting zoo"" after the concert for people to see and try instruments and to ask questions.
            //Lauda Musicam of Atlanta is an instrumental ensemble of recorders, viols, flutes, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, and percussion.
            //Uncommon Practice, an a cappella vocal ensemble specializing in music before Bach's ""common practice"" period, will assist.",
            //                TimeZoneId = "US Eastern Standard Time",
            //                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2015-05-17 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //                Address = address_StBarts,
            //                Comment1 = "The concert is free, but donations are accepted and appreciated."
            //            });

            //events.Add(new EventModel()
            //{
            //    Id = 17,
            //    Name = "Fright Night: The Eerie Renaissance",
            //    Description = @"Dark subjects have always held a place in music.  Lauda Musicam of Atlanta will provide a look at supernatural occurrences, death, and other morbid subjects using an array of historical instruments.  Uncommon Practice, an a cappella vocal ensemble specializing in music written outside Bach’s common practice period, will assist.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2015-11-13 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are accepted and appreciated."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 18,
            //    Name = "Where Did the Love Go? The Loveless Renaissance",
            //    Description = @"Love and romance have provided fodder for composers throughout history.  The loss of love, though, makes for even more interesting stories through music.  Lauda Musicam of Atlanta will perform medieval, renaissance, and baroque music as part of the Concert with a Cause concert series at Church of the New Covenant.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2016-02-21 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_ChurchOfTheNewCovenant,
            //    Comment1 = "The concert is free, but donations are accepted for a charity of the church's choice."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 19,
            //    Name = "The Musical Tribute: A Family & Children's Concert",
            //    Description = @"What better way to honor someone than to name a piece of music after them?  Lauda Musicam of Atlanta will perform works that bear the names of people, both unknown and famous.  Built into the performance will be demonstrations of the instruments and music forms for people less familiar with historical music. Members will lead a ""petting zoo"" after the concert for people to see and try instruments and to ask members questions. Lauda Musicam is an instrumental ensemble of recorders, viols, flutes, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, and percussion.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2016-05-15 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are accepted and appreciated."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 20,
            //    Name = "2016 Lauda Play Date",
            //    Description = @"Come join us for a day of music as we tour the workshop of George Kelischek in Brasstown, North Carolina.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2016-10-08 08:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_KelischeksWorkshop,
            //    Comment1 = "Please, follow the event flyer link below for the instructions and schedule.",
            //    LinkText = "Event Flyer",
            //    LinkHRef = "Content/flyers/FlyerKelischek.pdf"
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 21,
            //    Name = "Keyboards in Early Music",
            //    Description = @"During the Renaissance and Baroque periods, the organ and the harpsichord were used in home music, chamber music, and church services.  Shannon Gallier, music director at St. Bartholomew’s Episcopal Church, and Paula Curl will perform with Lauda Musicam and our partner ensemble Uncommon Practice in this concert of music featuring keyboard instruments.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2016-11-11 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are accepted and appreciated."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 22,
            //    Name = "Off the Beaten Path",
            //    Description = @"Lauda Musicam of Atlanta highlights the lesser-known composers of the Medieval and Renaissance periods.  The group will also perform some new music for old instruments, celebrating some of the repertoire that helped bring about the early music revival in the mid-20th century.  Lauda Musicam of Atlanta will perform as part of the Concert with a Cause concert series at Church of the New Covenant.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2017-02-26 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_ChurchOfTheNewCovenant,
            //    Comment1 = "The concert is free, but donations are accepted for a charity of the church's choice."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 23,
            //    Name = "A Trip to Old Spain",
            //    Description = @"Music from Spain has always had a special appeal. Interesting and asymmetrical rhythms have been incorporated in Spanish musical compositions for hundreds of years. In addition to a concert of both lively and lush Renaissance music, the members will lead a ""petting zoo"" after the concert. This will be the perfect stop after Mother’s Day brunch! Lauda Musicam is an instrumental ensemble of recorders, viols, flutes, harpsichord, sackbuts, shawms, harps, crumhorns, cornettos, percussion, and other historical instruments.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2017-05-14 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are accepted and appreciated."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 24,
            //    Name = "Lauda Musicam PlayDate at the Workshop of George Kelischek",
            //    Description = "Lauda Musicam offers this “field trip” to scenic Brasstown, North Carolina, as we tour the workshop and spend the afternoon playing music on capped reeds, recorders, and other instruments. Bring a picnic or sack lunch for the grounds.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2017-10-14 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_KelischeksWorkshop,
            //    Comment1 = "Free to Lauda Musicam Members; $10 for non-members."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 25,
            //    Name = "Brass in the Renaissance",
            //    Description = "Brass instruments played a large role in church and court. The Lauda Musicam brass ensemble will be joined by guests including Doug Lindsey, cornetto soloist, in a performance of sacred and secular music that helped define the style of the period. In addition, recorders, viols, flutes, percussion, shawms, and capped reed instruments will bring together the type of diverse performance audiences have come to expect from this ensemble.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2017-11-03 20:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are gratefully accepted."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 26,
            //    Name = "Blushes and Giggles: An Afternoon of Bawdy Music",
            //    Description = "Atlanta musicians John Maschinot and Linda Edwards are featured on this concert of music that is neither prim nor proper. Bagpipes will set the tone for this raucous concert, but Lauda Musicam will join John as he sings and plays his way through some brow-raising tunes! A reception and instrument “petting zoo” follow the concert.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-02-18 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_ChurchOfTheNewCovenant,
            //    Comment1 = "The concert is free, but donations are accepted for a charity as part the “Concerts With a Cause” concert series."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 27,
            //    Name = "Atlanta Recorder Society Consort Day",
            //    Description = "A longtime tradition to celebrate both Early Music Month and National Play-the-Recorder Month, Consort Day gives local early musicians a chance to perform on a collage concert. Lauda Musicam and other area soloists and ensembles perform. A reception follows the concert.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-03-18 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_ChurchOfTheNewCovenant,
            //    Comment1 = "The concert is free, but donations are accepted for a charity as part the “Concerts With a Cause” concert series."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 28,
            //    Name = "Lauda Musicam PlayDate—Early Masses",
            //    Description = "Lisle Kulbach leads this reading session of early Renaissance masses for instrumentalists and singers.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-04-07 14:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "Free to Lauda Musicam Members; $10 for non-members."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 29,
            //    Name = "Sephardic & Jewish Music",
            //    Description = "Jewish composers contributed wonderful music to the early music repertoire, though we often overlook their contributions. Lauda Musicam will perform traditional Sephardic tunes as well as beautifully composed art music from the Baroque period and earlier on this Mother’s Day concert. A “petting zoo” follows the concert.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-05-13 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are gratefully accepted."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 30,
            //    Name = "Lauda Musicam PlayDate at Kelischeks Workshop",
            //    Description = "Includes a tour of the Kelischek Workshop, a playing session (capped reeds welcomed!), time for lunch on the grounds, and an opportunity to shop for music, instruments, and accessories.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-10-20 10:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-10-20 16:30"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_KelischeksWorkshop,
            //    Comment1 = "Lauda Musicam’s PlayDates are music reading sessions open to everyone. PlayDates are usually themed playing sessions directed by a guest. Bring instruments and a music stand. PlayDates are free to Lauda Musicam members and $10 for non-members."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 31,
            //    Name = "Strings in the Renaissance",
            //    Description = "Viols, psalteries, harpsichords, and other instruments with strings have held a strong place in musical performances for centuries. Lauda Musicam of Atlanta’s full ensemble of winds and strings will join with musical guests in a concert featuring plucked and bowed strings.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-11-11 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-11-11 16:30"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are gratefully accepted.",
            //    LinkHRef = "/Content/flyers/ConcertPosterFullNov2018StBarts.pdf",
            //    LinkText = "Concert Flyer"
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 32,
            //    Name = "Strings in the Renaissance",
            //    Description = "Viols, psalteries, harpsichords, and other instruments with strings have held a strong place in musical performances for centuries. Lauda Musicam of Atlanta’s full ensemble of winds and strings will join with musical guests in a concert featuring plucked and bowed strings.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-11-18 15:30"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2018-11-18 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_JasperEpiscopalChurch,
            //    Comment1 = "The concert is free, but donations are gratefully accepted.",
            //    LinkHRef = "/Content/flyers/ConcertPosterFullNov2018HolyFamily.pdf",
            //    LinkText = "Concert Flyer"
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 33,
            //    Name = "Chamber Music for Early Instruments",
            //    Description = "Members of Lauda Musicam of Atlanta perform one-per-part music from the Medieval, Renaissance, and Baroque. The brass ensemble, the shawm ensemble, the flute ensemble, and others, perform some gems of the repertoire.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-02-17 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StLukeLutheranChurch,
            //    Comment1 = "The concert is free, but donations are accepted.",
            //    LinkHRef = "/Content/flyers/ConcertPosterFullFeb2019Chamber.pdf",
            //    LinkText = "Concert Flyer"
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 33,
            //    Name = "PlayDate with Phil Hollar",
            //    Description = "Franco-Flamish Madrigalists: The music of Arcadelt, Verdelot, and de Rore, directed by Phil Hollar.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-03-30 14:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-03-30 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "Lauda Musicam’s PlayDates are music reading sessions open to everyone. PlayDates are usually themed playing sessions directed by a guest. Bring instruments and a music stand. PlayDates are free to Lauda Musicam members and $10 for non-members.",
            //    LinkText = "Sign up via Surey Monkey",
            //    LinkHRef = "https://www.surveymonkey.com/r/JKMZ6NB"
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 34,
            //    Name = "Messe de Nostre Dame: Machaut's Medieval Masterpiece",
            //    Description = "Lauda Musicam joins with the choir of St. Bartholomew's Episcopal Church in this performance of the earliest known complete setting of the Ordinary of the mass. Machaut's work from the mid-14th century advanced four-part polyphony and set the stage for many other composers to write complete masses.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-05-12 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-05-12 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are gratefully accepted."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 35,
            //    Name = "Lauda Play Date",
            //    Description = @"Come join us for a day of music as we tour the workshop of George Kelischek in Brasstown, North Carolina.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-10-12 08:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_KelischeksWorkshop,
            //    Comment1 = "Please, follow the event flyer link below for the instructions and schedule.",
            //    LinkText = "Event Flyer",
            //    LinkHRef = "Content/flyers/PlayDates20192020.pdf",
            //    LinkText2 = "Signup Here",
            //    LinkHRef2 = "https://www.surveymonkey.com/r/JKMZ6NB"
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 36,
            //    Name = "Sunday Service Prelude",
            //    Description = "Periodically, some Lauda Musicam members play before the Sunday service at St. Bartholomew's Episcopal Church.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-11-03 10:15"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-11-03 10:30"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = ""
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 37,
            //    Name = "Music for Advent and Christmas",
            //    Description = "Much of the music we all have come to associate with Advent and Christmas is from the Medieval, Renaissance, and Baroque periods, proving that good music will, indeed, stand the test of time. In anticipation of the season, Lauda Musicam celebrates with music and instruments used hundreds of years ago.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-11-24 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    //EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-11-24 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are gratefully accepted."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 38,
            //    Name = "Prelude for the Children's Service",
            //    Description = "A group of Lauda Musicam members periodally plays prelude music before the start of the service at St. Bartholomew's Episcopal Church. Usually, the prelude lasts for 15-20 minutes.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-12-24 10:30"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = ""
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 39,
            //    Name = "Lauda Musicam Chamber Concert",
            //    Description = "Lauda Musicam has a large collection of reproduction instruments and the group puts them to use in this varied concert of small ensembles.  Since instruments tended to play in like groups, music performances were intimate and music ensembles were small. Lauda members will play repertoire on appropriate instruments, giving a look (or a listen) into performances as they originally sounded.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-02-09 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    //EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-02-09 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "The concert is free, but donations are gratefully accepted."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 40,
            //    Name = "Performance as a Part of the Atlanta Recorder Society Consort Day.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-03-08 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_MorningsidePresbyterian,
            //    Comment1 = ""
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 41,
            //    Name = "CANCELED - Play Date",
            //    //Description = "Jennifer Streeter leads a playing session at St. Bartholomew's Episcopal Church.",
            //    Description = "Due to the recent COVID-19 spread in Georgia, we have decided to postpone the Play Date",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-03-28 14:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-03-28 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    //Comment1 = "The playdate is free for the Lauda Musicam members and $10 for non-members.",
            //    //LinkHRef = "https://www.surveymonkey.com/r/JKMZ6NB",
            //    //LinkText = "Sign up via Survey Monkey",
            //    LinkHRef2 = "Content/flyers/Lauda2019-20playdateFlier.jpg",
            //    LinkText2 = "Printable Play Date flyer"
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 42,
            //    Name = "CANCELED - Music of Thrones",
            //    Description = "The Soundtrack of the Renaissance Court. Before musicians had to work side jobs as retail clerks to make ends meet, there was a time when wealthy patrons helped provide the means by which artists could create and perform. Queen Elizabeth I, the namesake of the Elizabethan era, is a prime example of how music and other arts can thrive given support. We will explore music from this iconic period, as well as looking at other works associated with nobility.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-05-03 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-05-03 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = "We have moved this concert to the next season due to COVID-19 pandemic."
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 43,
            //    Name = "Lauda Musicam Member Meeting and Playing Session",
            //    Description = "This year, member meeting will not be held in person. We are moving it online: please contact lauda.musicam@gmail.com for information.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-06-08 19:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-06-08 21:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = ""
            //});

            //events.Add(new EventModel()
            //{
            //    Id = 44,
            //    Name = "Sunday Service Prelude",
            //    Description = "Periodically, some Lauda Musicam members play before the Sunday service at St. Bartholomew's Episcopal Church.",
            //    TimeZoneId = "US Eastern Standard Time",
            //    Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-02-02 10:15"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2019-02-02 10:30"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
            //    Address = address_StBarts,
            //    Comment1 = ""
            //});

            events.Add(new EventModel()
            {
                Id = 45,
                Name = "CANCELED - Music of Thrones",
                Description = "The Soundtrack of the Renaissance Court. Before musicians had to work side jobs as retail clerks to make ends meet, there was a time when wealthy patrons helped provide the means by which artists could create and perform. Queen Elizabeth I, the namesake of the Elizabethan era, is a prime example of how music and other arts can thrive given support. We will explore music from this iconic period, as well as looking at other works associated with nobility.",
                TimeZoneId = "US Eastern Standard Time",
                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-05-03 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
                EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2020-05-03 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
                Address = address_StBarts,
                Comment1 = "We have moved this concert to the next season due to COVID-19 pandemic."
            });

            events.Add(new EventModel()
            {
                Id = 46,
                Name = "Lauda Musicam PlayDate",
                Description = @"
                    Presented by Daphna Mor, Sarah Mead, and Jody Miller. <br>
                    Lauda Musicam of Atlanta offers two PlayDates each year for our members and our friends to play music together and to dig deeper into historical music.
                ",
                TimeZoneId = "US Eastern Standard Time",
                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2023-03-25 09:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
                EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2023-03-25 16:30"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
                Address = address_AtlantaSpeechSchool,
                Comment1 = @"
                    Registration is $50 for members of Lauda Musicam of Atlanta and $100 for non-members. <br>
                    Non-members may join Lauda Musicam at the time of registration and then join at the $50 discount
                ",
                LinkHRef = "/PlayDateSpring2023",
                LinkText = "Addition information and registration",
            });

            events.Add(new EventModel()
            {
                Id = 47,
                Name = "Dance Party",
                Description = @"
                    Lauda Musicam collaborates with Atlanta Historic Dance in this concert of early dance music.
                    Dancing was an important part of society in the Renaissance and Baroque, creating a symbiotic relationship between dancers and musicians.
                    Dance treatises left information about choreography and musical accompaniment styles, both brought to life through this collaborative performance.
                    A short audience dancing lesson will follow the concert.
                ",
                Comment1 = "The concert is free, but donations are gratefully accepted.",
                LinkHRef = "https://www.facebook.com/atlantahistoricdance",
                LinkText = "Atlanta Historic Dance",
                TimeZoneId = "US Eastern Standard Time",
                Time = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2023-05-07 15:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
                EndTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse("2023-05-07 17:00"), TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time")),
                Address = address_StBarts
            });

            var cutoffTime = DateTime.UtcNow.AddDays(-1.0);

            var events2 = events
                .Where(ev => !ev.Time.HasValue || ev.Time.Value > cutoffTime)
                .OrderBy(ev => ev.Time ?? DateTime.MinValue)
                .ToList();

            var model = new HomePageModel()
            {
                Events = events2
            };

            return View("HomeIndex", model);
        }
    }
}
