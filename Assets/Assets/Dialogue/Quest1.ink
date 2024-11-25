-> main

=== main ===
Can you help me with something?
    + [Yes]
        -> chosen("Ok lets get started!")
    + [NO!]
        -> chosen("NO?! What do you mean NO?")

-> quest

=== quest ===
You saw the cottage before right?
 + [Yes]
        -> chosen("Ok,  ")
    + [NO!]
        -> chosen("NO?! What do you mean NO?")

=== chosen(question) ===
 {question}!
-> END