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
Nice, so there is a flag on the roof. Please fetch me it?
-> END

=== endDialogueNo ===
No? How can you even miss it?
Are you sure? Just go look for it!
-> END