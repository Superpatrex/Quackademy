# Quackademy VR

What it does
Quackademy VR is a quiz-taking platform designed to facilitate student-teacher interaction through captivating, interactive assignments powered by Unity XR technology. Within a virtual classroom, students can utilize their VR headsets to answer quiz questions while being closely monitored by their teacher. The teacher has the ability to control lesson plans and questions by seamlessly integrating their own JSON question sets, along with the ability to view the students progress, scores, and change lessons.

Inspiration
With a majority of team taking a VR course, we wanted to get ahead and get hands-on experience designing an application. We didn't start with a set challenge in mind but as time passed and our project grew, we became more passionate for its potential to connect individuals to learn in an interactive and engaging way which moved us to work harder.

How we built it
The foundation of Quackademy VR was established using Unity's core VR template, which provided a comprehensive set of packages to kickstart our project. We manipulated cameras and restricted the headset to a single camera, effectively dividing the runtime into two distinct components: an interactive VR experience for students and a monitoring interface for teachers. This allowed teachers to track student progress from their own computers without needing to immerse themselves in the VR environment. Through creative UI development, we successfully integrated 2D user interfaces into the 3D interactive environment, complete with customizable buttons that could be scripted in C#. Joined by lessons and question sets built in a simple yet effective .json so teachers could easily customize and create their own. These elements formed the essential building blocks of our project.

Challenges we ran into
Synced Collaboration. Unlike more conventional software applications, game development presented challenges in terms of version control. The process of transferring assets and scenes between computers frequently resulted in merge conflicts, leading to occasional setbacks throughout the project. Furthermore, certain packages became unresponsive on some of our computers as our project expanded. Additionally, we faced limitations due to having only two VR headsets, with only one available for testing in development mode. To overcome these hurdles, we designated one computer for developmental testing and asset generation, while the others focused on creating scripts and UI components. This approach allowed us to work simultaneously on different aspects and minimize conflicts.

Accomplishments that we're proud of
Splitting the cameras, enabling both the teacher (from the computer) and the student (from the VR headset) to interact simultaneously with different parts of the virtual environment by creatively manipulating camera angles. Additionally, we are pleased with our successful implementation of 2D assets and interactive UI elements within the 3D world, offering users a seamless and immersive experience.

What we learned
Our teamwork in a time-constrained environment improved steadily as the hours passed. We recognized the importance of task delegation to maximize productivity and identified instances where collaborative problem-solving was essential. This project served as a significant learning experience, particularly in the realm of Unity and 3D game development, as many of us had limited to no prior experience, but our skills rapidly grew as we progressed.

What's next for Quackademy VR
There are several features on our roadmap for Quackademy VR that we were unable to implement within the time constraints of Shellhacks. We originally envisioned Quackademy VR to support multiple students in the virtual classroom environment, and that vision remains intact. Additionally, we plan to introduce an interchangeable voice chat feature, allowing teachers to engage in two-way voice conversations with students while monitoring.
