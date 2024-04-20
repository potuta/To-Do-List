# About
This project was created for the purpose of learning the process of publishing a working application online, understanding c#, as well as to satisfy my curiousity as a student programmer.
There were two things that I wanted to achieve with this project:

- _**I wanted to successfully publish my application online or to a website for other people to install/download.**_

- _**I wanted the application to have a fully functional support for updates whenever I try to make changes to the application.**_

This is because I was curious as to how any software or applications are published online for public use, and how developers can provide updates to the application when it is already installed or downloaded by the user. 
<br><br>

## Experience
<p align="justify"> During this project I've encountered all sorts of errors, but the two in particular that gave me the most trouble are both related with the manifest file having some kind of issue. It is also both with ClickOnce deployment errors, InvalidDeploymentException (HashValidation) - which stated the File has a different computed hash than specified in manifest. As well as InvalidDeploymentException (ManifestLoad) - which stated the manifest may not be valid or the file could not be opened. </p>
  
<p align="justify"> I have done a lot of research and tried a lot of methods from other people online that have encountered similar errors but most of them didn't work for my situation. The problem with my situation is that when publishing the application locally or to a localhost it doesn't encounter any errors, not until I try to publish and set the installation url to a website that the error is given. Which gave me reason to believe that there's nothing necessarily wrong with the manifest file itself, but something is missing that somehow causes an error with the manifest file. However, the problem with me determining the error is that I have no clue how to solve it. Since solving this type of error requires extensive knowledge that are way beyond my capabilities at the moment, according to my research. Fortunately, I found an extremely helpful blog post by Jan Jones detailing a guide about building and publishing a ClickOnce installer on Github, after a seemingly endless cycle of searching for a solution, implementing a solution and ultimately failing. Therefore, huge thanks to Jan Jones who's the creator of the blog post for ultimately fixing my issue and making this project worth it: https://janjones.me/posts/clickonce-installer-build-publish-github/ </p>
<br>

## Images of the app
![Screenshot 2024-04-20 202953](https://github.com/potuta/To-Do-List/assets/166978464/cf079972-4d06-40a1-95b5-205edecce43d)
