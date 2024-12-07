-> main

=== main ===
Hello there!
I am the wise grand wizard, What brings you to my shop today?
    + [Do you have the spellbook of portals]
        -> chosen_portal
    + [This witch said you would know something about a portal spellbook.]
        -> chosen_witch

=== chosen_portal ===
Of course but why would a duck need a portal spellbook
    + [To get home.. This witch promised to help me]
        -> chosen_witch
    + [TO UNLEASH MAYHEM ACROSS DIFFERENT REALITIES]
        -> chosen_mayhem

=== chosen_witch ===
Oh, that's interesting indeed. But I can't give the book to just anybody.
 You have to answer me 5 questions.
    + [Ok, but only if you promise me the book]
        -> chosen_ok
    + [No way just give it to me]
        -> chosen_no

=== chosen_mayhem ===
I can't help you with that, I'm sorry.
    + [I was kidding, I need it to get back home]
        -> chosen_witch
    + [I was joking, this witch promised to help me home]
        -> chosen_witch

=== chosen_no ===
Okay, then you don't want the book.
    + [I need it I will answer your questions]
        -> chosen_ok
    + [No I want it I will answer your riddles]
        -> chosen_ok

=== chosen_ok ===
What is the hardest natural substance on Earth?
    + [Diamond]
        -> chosen_Q1Y
    + [Galvanized square steel]
        -> chosen_Q1N

=== chosen_Q1Y ===
That's right! It is diamond.
What are the three states of matter?
    + [Solid, liquid, gas]
        -> chosen_Q2Y
    + [Liquid, solid, plasma]
        -> chosen_Q2N

=== chosen_Q1N ===
No, I'm afraid your wrong.
What are the three states of matter?
    + [Liquid, plasma, steam]
        -> chosen_Q2N
    + [Solid, liquid, gas]
        -> chosen_Q2Y

=== chosen_Q2Y ===
Correct.
What is the name of the process where water changes from liquid to gas?
    + [Precipitation]
        -> chosen_Q3N
    + [Evaporation]
        -> chosen_Q3Y

=== chosen_Q2N ===
Close, but incorrect.
What is the name of the process where water changes from liquid to gas?
    + [Evaporation]
        -> chosen_Q3N
    + [Precipitation]
        -> chosen_Q3Y

=== chosen_Q3Y ===
Nice! You know your stuff.
Who was the first woman to fly solo across the Atlantic Ocean?
    + [Amelia Earhart]
        -> chosen_LastQY
    + [Harriet Quimby]
        -> chosen_LastQN

=== chosen_Q3N ===
Ahh, close one. I tought you would know this.
Who was the first woman to fly solo across the Atlantic Ocean?
    + [Harriet Earhart]
        -> chosen_Q4N
    + [Amelia Earhart]
        -> chosen_Q4Y

=== chosen_Q4Y ===
Yeah buddy, nice one!
Who was the third president of the United States?
    + [Thomas Jefferson]
        -> chosen_LastQY
    + [George Washington]
        -> chosen_LastQN

=== chosen_Q4N ===
I'm disappointed, you should have known that.
Who was the third president of the United States?
    + [George Washington]
        -> chosen_LastQN
    + [Thomas Jefferson]
        -> chosen_LastQY

=== chosen_LastQY ===
Yeah! You know your history.
You did well enough for my liking so I will give you this SPELLBOOK OF PORTALS!
->END

=== chosen_LastQN ===
Oh, this one you should have known.
You should have known all these, but you did well enough. You deserve this book.
->END