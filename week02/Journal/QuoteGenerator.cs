public class QuoteGenerator
{
    private List<string> _quotes = new List<string>()
    {
        "“We cannot solve problems with the kind of thinking we employed when we came up with them.” —Albert Einstein",
        "“Learn as if you will live forever, live like you will die tomorrow.” —Mahatma Gandhi",
        "“Stay away from those people who try to disparage your ambitions. Small minds will always do that, but great minds will give you a feeling that you can become great too.” —Mark Twain",
        "“When you give joy to other people, you get more joy in return. You should give a good thought to the happiness that you can give out.” —Eleanor Roosevelt",
        "“When you change your thoughts, remember to also change your world.” —Norman Vincent Peale",
        "“It is only when we take chances that our lives improve. The initial and the most difficult risk we need to take is to become honest.” —Walter Anderson",
        "“Nature has given us all the pieces required to achieve exceptional wellness and health, but has left it to us to put these pieces together.” —Diane McLaren",
        "“Fear of what other people will think is the single most paralyzing dynamic in business and in life. The best moment of my life was the day I realized that I no longer give a damn what anybody thinks. That’s enormously liberating and freeing, and it’s the only way to live your life and do your business.” —Cindy Gallop",
        "“The only way of discovering the limits of the possible is to venture a little way past them into the impossible.” ―Arthur C. Clarke",
        "“Worry is a misuse of imagination.” —Unknown",
        "“Courage is the most important of all the virtues because, without courage, you can’t practice any other virtue consistently.” ―Maya Angelou",
        "“I never look back, darling. It distracts from the now.” —Edna Mode",
        "“A year from now you will wish you had started today.” —Unknown",
        "“The reason we struggle with insecurity is because we compare our behind the scenes with everyone else’s highlight reel.” —Steve Furtick",
        "“Somewhere, something incredible is waiting to be known.” —Carl Sagan",
        "“I will not lose, for even in defeat, there’s a valuable lesson learned, so it evens up for me.” —Jay-Z",
        "“I do not try to dance better than anyone else. I only try to dance better than myself.” —Arianna Huffington",
        "“If you don’t risk anything, you risk even more.” —Erica Jong",
        "“You’ll never get bored when you try something new. There’s really no limit to what you can do.” —Dr. Seuss",
        "“I think it’s intoxicating when somebody is so unapologetically who they are.” —Don Cheadle",
        "“You can never leave footprints that last if you are always walking on tiptoe.” —Leymah Gbowee",
        "“If you don’t like the road you’re walking, start paving another one.” —Dolly Parton",
        "“If it makes you nervous, you’re doing it right.” —Childish Gambino",
        "“What you do makes a difference, and you have to decide what kind of difference you want to make.” —Jane Goodall",
        "“I choose to make the rest of my life the best of my life.” —Louise Hay",
        "“In order to be irreplaceable one must always be different.” —Coco Chanel",
        "“Anything can make me stop and look and wonder, and sometimes learn.” —Kurt Vonnegut",
        "“People’s passion and desire for authenticity is strong.” —Constance Wu",
        "“A surplus of effort could overcome a deficit of confidence.” —Sonia Sotomayor",
        "“Doubt is a killer. You just have to know who you are and what you stand for.” —Jennifer Lopez",
        "“No one changes the world who isn’t obsessed.” —Billie Jean King",
        "“I learned a long time ago that there is something worse than missing the goal, and that’s not pulling the trigger.” —Mia Hamm",
        "“Some people want it to happen, some wish it would happen, others make it happen.” —Michael Jordan",
    };

    public string GetRandomQuote()
    {
        Random random = new Random();
        int index = random.Next(_quotes.Count());
        return _quotes[index];
    }
}