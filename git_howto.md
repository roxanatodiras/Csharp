# Hnts for git

Creating a repository
```sh
git init
```
Adding a file to the repository
```sh
git add <file_name>
```
Commiting a change
```sh
git commit -m "the message about the change"
```
Checking the log of the changes and the number of the commit in one line
```sh
git log --oneline
```
Switching through commits
```sh
git checkout <number_of_commit>
```
Switching to the last commit
```sh
git checkout master
```
>or main instead of master as in my case

Restoring a version when made some unwanted changes
```sh
git restore <file_name>
```
Checking the status of the file
```sh
git status
```
Checking the differences between the current file and the last saved version of the file
```sh
git diff
```
Configuring the name of the user
```sh
git config --global user.name
```
Configuring the email of the user
```sh
git config --global user.email
```

Showing all the branches
```sh
git branch
```

Switching between branches
```sh
git checkout <branch_name>
```

