using ByPassingFilters.Models;
using System.Collections.Generic;
using System.Linq;

namespace ByPassingFilters.Repository
{
    public class QuoteRepository
    {
        private List<Quote> quotes;

        public QuoteRepository()
        {
            quotes = new List<Quote>()
            {
                new Quote()
                {
                    Author = "Friedrich Nietzsche",
                    Content = "Whoever fights monsters should see to it that in the process he does not become a monster. And if you gaze long enough into an abyss, the abyss will gaze back into you."
                },
                new Quote()
                {
                    Author = "Eckhart Tolle",
                    Content = "Any action is often better than no action, especially if you have been stuck in an unhappy situation for a long time. If it is a mistake, at least you learn something, in which case it's no longer a mistake. If you remain stuck, you learn nothing."
                },
                new Quote()
                {
                    Author = "John Adams",
                    Content = "Democracy... while it lasts is more bloody than either aristocracy or monarchy. Remember, democracy never lasts long. It soon wastes, exhausts, and murders itself. There is never a democracy that did not commit suicide."
                },
                new Quote()
                {
                    Author = "Leonardo da Vinci",
                    Content = "The divisions of Perspective are 3, as used in drawing; of these, the first includes the diminution in size of opaque objects; the second treats of the diminution and loss of outline in such opaque objects; the third, of the diminution and loss of colour at long distances."
                },
                new Quote()
                {
                    Author = "Benjamin Franklin",
                    Content = "For having lived long, I have experienced many instances of being obliged, by better information or fuller consideration, to change opinions, even on important subjects, which I once thought right but found to be otherwise."
                },
                new Quote()
                {
                    Author = "Nelson Mandela",
                    Content = "Education is the most powerful weapon which you can use to change the world."
                },
                new Quote()
                {
                    Author = "Edgar Allan Poe",
                    Content = "Deep into that darkness peering, long I stood there, wondering, fearing, doubting, dreaming dreams no mortal ever dared to dream before."
                },
                new Quote()
                {
                    Author = "Arthur Schopenhauer",
                    Content = "A man can be himself only so long as he is alone, and if he does not love solitude, he will not love freedom, for it is only when he is alone that he is really free."
                },
                new Quote()
                {
                    Author = "George Eliot",
                    Content = "We long for an affection altogether ignorant of our faults. Heaven has accorded this to us in the uncritical canine attachment."
                },
                new Quote()
                {
                    Author = "Galileo Galilei",
                    Content = "I notice that young men go to the universities in order to become doctors or philosophers or anything, so long as it is a title, and that many go in for those professions who are utterly unfit for them, while others who would be very competent are prevented by business or their daily cares, which keep them away from letters."
                },
                new Quote()
                {
                    Author = "John McEnroe",
                    Content = "I did a terrible job of composing myself. I was a spoiled brat from Long Island who benefitted from the energy of New York."
                },
                new Quote()
                {
                    Author = "Bob Marley",
                    Content = "The greatness of a man is not in how much wealth he acquires, but in his integrity and his ability to affect those around him positively"
                },
                new Quote()
                {
                    Author = "Molière",
                    Content = "A wise man is superior to any insults which can be put upon him, and the best reply to unseemly behavior is patience and moderation."
                }
            };
        }

        public List<Quote> Search(string search)
        {
            return quotes.Where(q => q.Content.Contains(search, System.StringComparison.OrdinalIgnoreCase) || 
                                     q.Author.Contains(search, System.StringComparison.OrdinalIgnoreCase))
                                .ToList();
        }
    }
}
