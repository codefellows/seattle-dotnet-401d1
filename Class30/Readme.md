![cf](http://i.imgur.com/7v5ASc8.png) Lecture 27 : HTTP/SSL
=====================================

## Demo
1. Enable SSL/HTTPS on our site
2. Review Kestral

## Readings
[Enforcing SSL](https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl)
[Kestral](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel?tabs=aspnetcore2x)

## Coding Challenge
Animal Game:

Create a game where a user thinks up an animal, and the program's simple A.I tries to guess
what it is. The program is a lerning system, so over time, it gets better at guessing the user's animal.

the program stores information about animals in a binary tree. Each internal node holds either a yes or a no that guides 
the user down left or the right branch. The leaf nodes represent an animal.

If the system gets the animal wrong, then the user puts in the animal they were thinking of, and a potential question that could have 
made the computer successful in guessing, and that animal and question gets added to the node list.

- Using your "data-structures" repository -
  - add a folder and label it `Binary Search Trees`
  - add the code on a branch from this challenge into this repo
  - Your Readme document should include your notes about the challenge.
	- What did you learn?
	- Where did you look?
	- What notes did you use to help you successfully complete the challenge?
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas