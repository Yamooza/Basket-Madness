﻿-> main

=== main ===
Oh, hi your back allready.
And you have the book. Nice!
Give it to me.
    + [Give the book]
        -> chosen_give
    + [Don't give it]
        -> chosen_no

=== chosen_give ===
Now I can return you home.
Are you ready.
    + [Yes, of course.]
        -> ending_finally
    + [No, give me some time.]
        -> chosen_time

=== chosen_time ===
...
...
Are you ready to go home.
    + [Yes. (Give the book)]
        -> ending_finally
    + [No.]
        -> chosen_no

=== chosen_no ===
What?! Don't you want to go back home? 
    + [Yes I do]
        -> ending_yes
    + [No!!]
        -> ending_no

=== ending_yes ===
Ok so give it
    + [(Give the book)]
        -> ending_finally
    + [(Give the book)]
        -> ending_finally

=== ending_no ===
Ok so have fun I won't help you.
    + [Please (give the book)]
        -> ending_finally
    + [(Give the book)]
        -> ending_finally

=== ending_finally ===
Okay, for you to get home you will have to fight the timekeepper.
Go forward and jump in to the portal.
        -> END