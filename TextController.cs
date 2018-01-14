using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {bed, tr_awake_0, ball_0, owner_lick, bed_awake, tr_awake_1, ball_1, off_bed, back_door, tr_awake_2, pee_floor, wait_patient, eat_tr, ball_2};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.bed;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.bed) {
			state_bed();
		} else if (myState == States.tr_awake_0) {
			state_tr_awake_0 ();
		} else if (myState == States.ball_0) {
			state_ball_0 ();
		} else if (myState == States.owner_lick) {
			state_owner_lick ();
		} else if (myState == States.bed_awake) {
			state_bed_awake ();
		} else if (myState == States.ball_1) {
			state_ball_1 ();
		} else if (myState == States.tr_awake_1) {
			state_tr_awake_1 ();
		} else if (myState == States.off_bed) {
			state_off_bed ();
		} else if (myState == States.tr_awake_2) {
			state_tr_awake_2 ();
		} else if (myState == States.pee_floor) {
			state_pee_floor ();
		} else if (myState == States.back_door) {
			state_back_door ();
		} else if (myState == States.ball_2) {
			state_ball_2 ();
		} else if (myState == States.eat_tr) {
			state_eat_tr ();
		} else if (myState == States.wait_patient) {
			state_wait_patient ();
		}  
	}
	
	void state_bed () {
		text.text = "You open your sleepy eyes and instantly are keenly aware " +
					"of your presence. You are Brenna. You are a dog. " +
					"You want to play ball.\n\n" +
					"Press 1 to smell your best friend TR\n" +
					"Press 2 to lick Owner's face\n" +
					"Press 3 to play with your ball\n";
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) {
			myState = States.tr_awake_0;
		} else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) {
			myState = States.owner_lick;
		} else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) {
			myState = States.ball_0;		
		}
	}
	
	void state_tr_awake_0 () {
		text.text = "As you press your nose to his head, TR turns to face you with wary eyes. " +
					"He doesn't seem to dislike your sniffs, but he doesn't seem " +
					"particularly thrilled either. Indifferent at best. Still, " +
					"you love him with your whole heart.\n\n" +
					"Press RETURN/ENTER to see what else is going on in the bed";
		if(Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myState = States.bed;
		}
	}
	
	void state_ball_0 () {
		text.text = "The florescent yellow calls you from deep within your soul. " +
					"This ball is your destiny, your hopes, and your dreams. " + 
					"You swat it around a few times, even biting it once or twice. " +
					"Joy spreads from within; however, something inside you longs for more. " +
					"More than this.\n\n" + 
					"Press RETURN/ENTER to see if you can find a way to make your dreams come true";
		if(Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myState = States.bed;
		}
	}
	
	void state_owner_lick () {
		text.text = "Fearing it's been too long since you last expressed love to Owner, despite " +
					"the passing of nighttime and Owner's sleeping state, you begin to plant big " +
					"fat kisses to Owner's face. Unable to control your waggging tail from excitement, you whip TR " +
					"in the face, causing him to stir ever so slightly, but not bothered enough to " +
					"actually move. Owner wakes up and giggles, obviously pleased at your gift.\n\n" + 
					"Press RETURN/ENTER to continue";
		if(Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myState = States.bed_awake;
		}
	}
	
	void state_bed_awake() {
		text.text = "Oh boy, Owner is awake now! The day seems brighter, TR seems impossibly cuter, the bed " + 
					"is more comfortable, and the ball is screaming even louder. 'Play with me,' " + 
					"it calls to you. How could you refuse? How can you get its voice out of your head?\n\n" +
					"Press 1 to smell TR\n" +
					"Press 2 to play with your ball\n" +
					"Press 3 to get off the bed\n";
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) {
			myState = States.tr_awake_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) {
			myState = States.ball_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) {
			myState = States.off_bed;		
		}
	}
	
	void state_ball_1 () {
		text.text = "A feeling of longing burns deep inside, and you attempt to communicate this " + 
					"to Owner with a sorrowful look as you playfully attack the round ball that " +
					"holds the key to your future happiness. Without playing ball with Owner, " +
					"life is meaningless. Life has no purpose without ball. Ball is life.\n\n" +
					"Press RETURN/ENTER to try to manifest your dreams";
		if(Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myState = States.bed_awake;
		}
	}
	
	void state_tr_awake_1 () {
		text.text = "Now receiving some head scritches from Owner, TR is laying on his back, " +
					"clearly pleased with his current situation. You can't help but to place " +
					"your nose on his exposed stomach and give a sniff. TR takes this as a notion " +
					"of play, and swats at your face. You let out a sigh. You wonder if you'll ever " +
					"understand each other the way you wish you could.\n\n" +
					"Press RETURN/ENTER to see what else you can do";
		if(Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myState = States.bed_awake;
		}
	}
	
	void state_off_bed () {
		text.text = "Agh! You're off the bed now, but Owner is still in bed! There must be " +
					"something you can do to get Owner's attention. You kinda need to pee, but you're " +
					"mostly worried about making ball happening ASAP.\n\n" +
					"Press 1 to go to the back door, the entryway to Ball Heaven\n" + 
					"Press 2 to smell TR, desperately\n" +
					"Press 3 to pee on the floor\n";
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) {
			myState = States.back_door;
		} else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) {
			myState = States.tr_awake_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) {
			myState = States.pee_floor;		
		}
	}
	
	void state_tr_awake_2 () {
		text.text = "TR, still blissfully enjoying the Gift of Life, needs more attention. You, as a smart dog," +
					"are acutely aware of Owner's pleasure when you are gentle with TR. As you gingerly approach, " +
					"TR directs his attention to you, his little nose going into overdrive. When you noses meet, " +
					"an overwhelming amount of cooing comes from Owner, and you know you've done your job. However, " +
					"Owner remains in bed.\n\n" +
					"Press RETURN/ENTER to see what else could get Owner out of bed";
		if(Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myState = States.off_bed;
		}
	}
	
	void state_pee_floor () {
		text.text = "Brenna, no... How could you? 'Go lay down', Owner calls from what seems " +
					"like a distance. Everything is narrowing in. Sounds fading. Vision fading. Ball isn't happening now. Or ever.\n\n" +
					"Game Over.";
	}
	
	void state_back_door () {
		text.text = "Of course, the door is closed. This door singlehandedly blocks the path to the " +
					"everlasting room with never-ending space for ball playing. You let out a doggy sigh, " +
					"knowing that the only way to open the door is for Owner to do it." +
					"Press 1 to wait patiently\n" + 
					"Press 2 to eat TR in a blind panic\n" + 
					"Press 3 to play ball";
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) {
			myState = States.wait_patient;
		} else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) {
			myState = States.eat_tr;
		} else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) {
			myState = States.ball_2;		
		}
	}
	
	void state_ball_2 () {
		text.text = "You are increasingly getting frenzied about not playing ball. How does anyone " +
					"live like this? A ball-less life? You NEED ball. And you NEED it now. As one " +
					"takes a drag of a cigarette, you pounce the tiny ball " +
					"knowing that it won't fix everything but that it will temporarily relieve the pain, " +
					"if just for a moment.\n\n" +
					"Press RETURN/ENTER to open The Door To TryT o PLaY BALL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
		if(Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myState = States.back_door;
		}
	}
	
	void state_eat_tr () {
		text.text = "You have done the unthinkable. Brenna, was ball worth it?\n\n" +
					"Was it?\n\n" +
					"Game Over.";
	}
	
	void state_wait_patient () {
		text.text = "As sure as cleanliness is next to dogliness, patience is a virtue. " +
					"Moments pass, nearing infinity, before Owner sleepily walks in, ball thrower " +
					"in hand. You fear you might ascend to Heaven in your moment of euphoria, " +
					"missing the opportunity to play ball. Owner gives you a moment to sloppily relieve yourself," +
					"then trots down the outside stairs, throwing the ball. And in that moment, " +
					"you know you would do ANYTHING to Play Ball.\n\n" +
					"You Win.";
	}
	
}
