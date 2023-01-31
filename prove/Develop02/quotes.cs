using System;
using System.Collections.Generic;
//This class will generate random quotes.

public class QuotesQuenerator
{
    public List<string> _quotesList = new List<string>
{
    "Let people repent. Let people grow. Believe that people can change and improve. Is that faith?\n" +
    "Yes! Is that hope? Yes! Is that charity? Yes! Above all, it is charity, the pure love of Christ.\n" +
    "If something is buried in the past, leave it buried.\n" +
    "- Elder Jeffery R. Holland",
    "Faith in the Savior taught me that no matter what happened in the past, my story could have a\n"+
    "happy ending.\n"+
    "- President Dieter F. Uchtdorf",
    "How we live our lives increases or diminishes our faith. Prayer, obedience, honesty, purity\n"+
    "of thought and deed, and unselfishness increase faith. Without these, faith diminishes.\n"+
    "- Elder Neil L. Andersen",
    "Do not expect to become perfect at once. If you do, you will be disappointed. Be better today\n" +
    "than you were yesterday, and better tomorrow than you are today.\n"+
    "- Lorenzo Snow",
    "If we are striving, if we are working, if we are trying, to the best of our ability,\n"+
    "to improve day by day, then we are in the line of our duty.\n"+
    "- Heber J. Grant"
};

    public int _newListIndex;
    public string Display()
    {
        var random1 = new Random();
        _newListIndex = random1.Next(_quotesList.Count);
        string prompt1 = (_quotesList[_newListIndex]);
        return prompt1;
    }
}