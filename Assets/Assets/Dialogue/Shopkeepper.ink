-> main

=== main ===
Hello there!
I am the wise grand wizard, what brings you to my shop today?
    + [Do you have the spellbook of portals]
        -> chosen_portal
    + [This witch said he can bring me home with the book]
        -> chosen_witch

=== chosen_portal ===
Of course but why would a duck need a portal spellbook
    + [To get home.. This witch promised to help me.]
        -> chosen_witch
    + [TO UNLEASH MAYHEM ACROSS DIFFERENT REALITIES]
        -> Chosen_mayhem

=== chosen_witch ===
Oh, thats interesting indeed.
I can help you with this but it will cost 5 gold coins 
    + [(buy the book)]
        -> endDialogueYes
    + [(try to persuade to give the book for free)]
        -> chosen_persuade

=== Chosen_mayhem ===
I can't help you with that Im sorry.
    + [I was kidding, I need it to get back home]
        -> chosen_witch
    + [I was joking, this witch promised me to help me get back to my realm]
        -> chosen_witch

=== chosen_persuade ===
...
    + [Please, I don't have the gold and I need to get back home.]
        -> endDialogueplease
    + [JUST GIVE ME IT AND WE WON'T HAVE PROBLEMS!!!]
        -> endDialogue

=== endDialogueYes ===
Pleasure doing business with you 
-> END

=== endDialogue ===
Problems? HAHAHA
I could just smite you, if I wanted.
-> chosen_payup

=== endDialogueplease ===
Im sorry but I can't give it for free
-> chosen_payup

=== chosen_payup ===
...
    + [Pay the 5 coins]
        -> endDialogueYes
    + [Pay the 5 coins]
        -> endDialogueYes