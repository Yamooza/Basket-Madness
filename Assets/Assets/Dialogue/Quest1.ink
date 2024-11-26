-> main

=== main ===
Can you help me with something?
    + [Yes]
        -> chosen("Ok lets get started!")
    + [NO!]
        -> chosen("NO?! What do you mean NO?")
              === chosen(question) ===
 {question}!  
Did you see the cottage before?
    + [Yes]
        -> chosen("Nice, so there is a flag on the roof can you please fetch me it.")
    + [NO!]
        -> chosen("No? How can you even miss it?")
 -> END