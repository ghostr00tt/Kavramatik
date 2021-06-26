Kavramatik - Concept Teaching for Students with Special Needs

(Screenshots are at the bottom.)

General Structure

Working Structure

The user, who encounters the login screen, can access the system with an e-mail and password if he is registered, or by registering or not registering if he does not. After the login screen, the user will select the category of the concept he wants to learn. The user who chooses the category will be directed to the screen where the concepts belonging to the category are displayed and the concept they want to learn color, size, direction, number, etc.) will go to a 2-stage learning process.

In the two-stage learning model, the user will first see the concept he chooses and a concept different from the one he chooses 4 times. At this stage, the place of the learned concept does not remain constant and changes constantly, so the possibility of the user to act by heart is eliminated. Again, at this stage, the user who clicks on the desired concept will name the concept. with a TipBox (Information Box) and can also hear audibly with the help of Text-To-Speech, and when he clicks on the item that is not a concept he chooses, he receives an audible response as "This concept is not X". After repeating this process 4 times, the user can hear it audibly. The second stage is to receive feedback and move on to the reinforcement of learning.

In the second part, the user is asked to distinguish the concept he learned in the previous stage from a concept that has nothing to do with that concept. When he clicks on the item that has nothing to do with the concept, he returns with Text-To-Speech as "This concept is not X" and if he clicks on the correct concept, a MessageBox will appear. Box) and "You're Wonderful" is returned after this process repeats itself 4 times, and the user is considered to have completed the relevant concept. When he switches to another concept in the same category, when he comes across the concept he has learned before, this time the name of the concept instead of the return "This concept is not X" It is said aloud to the user, in this way, it is aimed to reinforce the learning by showing the previously taught concept.

Development Environment

The application was developed in the .Net Framework environment using the C# programming language with the Visual Studio(2019) IDE in the Windows environment.

MySQL was used in database selection, and Json text format was used for database communication with the application.

In the design phase, due to the low compatibility of Windows Forms elements with today's design elements, Bunifu Design Forms were used to provide a more modern appearance to both buttons, text boxes and other elements.

In order to manage resource usage effectively and to prevent possible memory overflows, a control mechanism is provided to prevent a window from reopening after opening pop-up windows. , but when the user wants to open another "Colors" page, another window is not opened, the open window is brought forward.

Dubbing

Since the use of the Text-To-Speech method for voice-over is deemed appropriate for the project process, using the bing translator with the help of a browser opened in the background with the help of the System.Windows.Forms.WebBrowser library "https://www.bing.com/translator/?from=tr&to We performed the vocalization process by sending the string expression to the URL =en" as a parameter and reflecting the response returned in the form of a voice to the user. The url that the browser running in the background will go to is specified, and the "tta_input_ta" parameter on the TR-EN translation page (where Turkish text is entered in the Turkish English translation section. field) we give the text we want to voice and we perform the Turkish voiceover process by triggering the play button.

categories

The categories aimed to be taught within the scope of the project are;

-Colors

-Dimensions

-Shapes

-Quantities

-Directions

-Numbers

-The senses

-Feelings

-Contrasting Concepts

It has been designed as 9 different categories. If we talk about the content of the category;

Colors

Colors category includes red, blue, yellow, orange, green, purple, black and white.

Dimensions

In the size category, there are large-small, narrow-wide, thin-thick, long-short sizes.

shapes

In the category of shapes, there are circle, square, triangle, rectangle, ellipse shapes.

Quantities

Quantities category includes more or less, heavy-light, empty-full, whole-quarter/half quantities.

directions

In the category of directions, there are directions in front, behind, under, in, above, and next to it.

numbers

Numbers category includes numbers 0,1,2,3,4,5,6,7,8,9.

senses

The senses category includes sweet, salty, bitter, sour, cold, hot.

Feelings

In the category of emotions, there are happy, sad, angry, scared, happy emotions.

Working Structure of the System

At this stage, the process of navigating within the application and operating the screen function will be explained.

Login

The user who is a member will be able to log in with their information, a user without a membership will be able to register via the "Register now" redirect, and the user who does not request these will be able to access the application directly anonymously.

Selection Screen

Game – Training orientation will be carried out in this area.

Education – Categories

At this stage, the user will recognize the concepts/categories that he can study and continue with the category he wants. When the mouse cursor is hovered over the images, the category name is printed with the TipBox and the background of the image becomes red.

Education – Concept

The "Colors" category has been selected from the categories. After selecting the category, the user is expected to click on the desired concept.

Education - Learning

An index number is sent to the training stage with the concept selected on the concept screen and the training process is shaped according to the index number.

In this example, the color "Red" is chosen for learning. If we talk about the plot, firstly, the image of the selected concept appears as the name of the concept that the image belongs to, and secondly, it is a different concept from the related concept and "This concept is not X". If the user clicks on the relevant concept, he or she will be able to hear the name of the concept audibly, and when he clicks on the image that is different from the concept, he will hear a voice again as "This concept is not X". These steps are repeated 4 times and the place of the selected concept is not fixed, it starts from the left and changes place in the form of right-left. .

In addition, in this example, the user who completes the color red will now hear the name of the concept he has learned, instead of hearing the sound "This concept is not X" since he has completed the red color when he starts learning the green color, thus it is aimed that the user will reinforce the concept he has learned.

After it is done again, the "Next" text on the button changes to "Skip to Practice" and when the button is clicked, the reinforcement phase that we want the user to choose will be passed. Education – Reinforcement

At this stage, the user will not proceed until he clicks on the correct image. When he clicks on the wrong image, the "This concept is not X" sound will be heard.

When the user makes the right choice, a message box appears on the screen with the voice response of "You found the right concept, you are amazing" and it is said that you are great in writing. This process is repeated 4 times.

When it is completed, it is shown to the user in writing that the concept has been completed, and it is returned to the menu with the relevant directions.

Game – Concept Matching

With the help of the pop-up window that appears, the user selects the concept they want to match in the matching game. After clicking start, the pop-up window used for selection will become invisible.

In the concept matching game, 2 pieces of a concept image are created from a concept image and these concepts are asked to be matched with each other at random. In addition, points are added to the user's score line for each completion.

When the user, who has 3 hints, clicks on the hint button, he can see the placement of the cards for 900ms (approximately 1 second).

Result

As a result, with this project, a structure that will directly or indirectly contribute to the learning of the basic concept of students with special needs has been designed.

As they get correct results, it is aimed to attract the user with written and audio feedbacks given to the user, and the whole system is built on this. The inclusion of an additional point system in the system is an incentive for students to learn more and get more points if they are used by a teaching center. planned and implemented to be effective.
