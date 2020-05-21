# Trial Exam:
IELTS Online Trial Exam - Web application.

In this folder, you can find some codes which I and my teacher wrote while developing ieltstrial.com.
This Web Application developed for those who are planning to take official IELTS exams.Project developed for Roof Academic Training - ISO 9001-2015 certified education company specialized in language and international exams preparation. Online IELTS trial exams are held regularly by the center in partnership with British Council Azerbaijan.These tests are prepared by specifically certified teachers.As far as we know, this project is the first online IELTS Computer Delivered trial exam.We have tried to develop the exact same exam structure that British Council gives for students who take the official exam.

# General structure of exam application:
Generally, exam is the same as the official computer delivered / paper based exam like IELTS.
Trial exams are held in every week.Questions are prepared by British Council Azerbaijan with the help of specifically certified teachers.Students who want to test their skills before taking the official exam, firstly signing up for the website, answering few survey questions about themselves and then registering for the available exams.After the exam finished, students again answer few questions about their experience.

# Exam rules:
- Listening section starts first. Moving on between parts disabled. Section lasts 35-40 minutes and have 40 questions. Application will move to the next part automatically when audio finishes. 
- Reading section starts automatically after listening section ends. Moving on between passages enabled. Section lasts 1 hour and have 40 questions.
- Writing section starts automatically after reading section ends. Moving on between tasks enabled. Section lasts 1 hour and have 2 passages.

# Application rules:
- Exams regularly start at 10 AM and being active for the next 3 hours.
- When authorized person starts the exam from control panel, session for the exam starts. Session's clean time is 3 hours. It means that after session starts, students will only have 3 hours to solve exam questions. For example: Let's assume that students didn't join to the exam when it started. Then students will lose some of their time depending on the time when they joined to the exam. 
More examples: Exam will start at 10 AM. John forgot to wake up and joined to exam at 12:00. He will start from listening and will move on. But because he joined to the exam 2 hours late, he will not have full time to finish reading and writing section: Listening 35-40 minutes, Reading 1 hour. Total of 1 hour 35-40 minutes. Exam was started at 10 AM and session's clean time was 3 hour. Which means that session will close itself at 13:00. Because John has joined to the exam at 12:00, he will only able to finish listening section. He will only have 20 or 25 minutes to look at reading questions. This works like this for every section.
- Students who enrolled for the exam, must open exam page only in one browser. If same exam from same account is opened in two different browser, then listening section and other sections will not work properly. We developed this feature to avoid possible cheatings.
- For the best experience, we reccommend to you use computer while doing listening section.


# How application works:
Students who enrolled for the exam cannot start to exam until exam time starts.Also authorized people who check the control panel decide which students can participate in the exam. Exams are free for the Roof Academic Training students and paid for students who enroll outside the course.After reading instructions for every section, when students press "Start the section" button remaining section starts and the time that given for the section begins.If some student disconnects from the exam or accidentally closes exam tab then he or she can come back and continue where he/she left off.But because he or she pressed the "Start" button, the time will continue to decline, regardless of which time interval he or she was missing.That's why students must try not leave the exam after pressing the "Start" button.Exam starts with Listening section.Listening section generally lasts between 35-40 minutes.Each part lasts as much as its audio's length.If student leaves the exam after pressing "Start the listening section" button during listening section, when he or she comes back they will join the exam where were their time left off.Which means they can miss some audios or even parts.Also students can't access to the audios.Because we disabled the right click and "view inspect, view page source" in listening section.Every beginning of the part application gives 30 seconds for students to look at the questions.Then audio starts.After end of the audio's first 2.5 minutes, again application gives 30 seconds for students to look at the rest of the questions that reamin in the active part.After each part ends, applicaton gives 2 minutes for students to check their all answers in the following part.This structure happening in every part except part 4. Part 4 has no gap between beginning and end (like in the real exam).After listening section ends reading starts.In reading section students will have 1 hour to answer 40 questions.After reading ends writing starts.Writing also lasts 1 hour and students can move between two sections whenever they want.To avoid the cheating in writing section, we disabled copy-paste (right click and ctrl+c and ctr+v) shortcuts. We did this because some students may try to copy or past the answers they found on the internet. 

# Future updates:
In the future, we will bring categorized exams with some special offers.Along with that, we are planning to bring online support system, sample exam section to the homepage, students' profile section with their past exam results, online payment function and etc.

# Control panel / Admin panel for authorized people:
- Authorized person can manage exam questions for every part.
- Can see and access to all users who have registered for the website and specified exam.
- Can calculate all users' overall score for the specified exam with the help of system.
- Can add any users to specified exam even users didn't register for the exam by themselves.
- Can see every user's personal answer related to specified question & section with right answers for the question and user's answer to the specified question.
- Can download users' overall scores with their personal details to the excell file.
- Can send overall scores and each section's scores to the users' registered emails with one click.

# Special thanks to who helped us to check system and find bugs during development process:
- Barish Namazov
