-> main

=== main ===
Can you help me with something?
    + [Yes]
        -> chosen_yes
    + [NO!]
        -> chosen_no

=== chosen_yes ===
Ok, let's get started!
Did you see the cottage before?
    + [Yes]
        -> endDialogueYes
    + [NO!]
        -> endDialogueNo

=== chosen_no ===
NO?! What do you mean No?!
Just help me with this please.
Did you see the cottage before?
    + [Yes]
        -> endDialogueYes
    + [NO!]
        -> endDialogueNo

=== endDialogueYes ===
There is an oldman in the shack. The oldman should have a spellbook of portals.
But beware the oldman always gives puzzles.  
-> END

=== endDialogueNo ===
No? How can you even miss it?
Are you sure? Just go look for it!
Go in the cottage and ask the oldman for a spellbook of portals.
But beware the oldman always gives puzzles.  
-> END