# Ezra Full Stack developer test

## Overview

This is a take home test for Ezra. Your goal will be to implement and improve various stub methods in the frontend and backend. You're able to choose whichever frontend framework you wish to complete the test (ie. only complete the angular OR react OR vue not multiple).

Overall the test should take no more than 4 hours to finish, but you are welcome to take more time if you wish, and it doesn't have to be in one stretch.

To complete this test you will need the following
- dotnet core (we used and will test on 3.1): https://dotnet.microsoft.com/download/dotnet-core/3.1
- sqlite (we used and will test on 3.32.3): https://www.sqlite.org/download.html
- nodejs (we used and will test on 12.16.1): https://nodejs.org/en/download/
- we will be testing the frontend on the most recent version of Chrome

When ready to start fork this repository, work on it, and then when complete send us an email letting us know along with the repository url, which frontend framework you've decided to use, anything you were unable to complete, and how long you spent on the test. We'd also appreciate any feedback you have for us about the test (too easy/hard, confusing instructions, difficult to set up). You have maximum 1 week to complete the test and get it back to us.

## Goal

### Front end

1. Complete `render` and `addMember` methods in the add member page
2. Complete `editMember` and `deleteMember` methods in the home page

    Note: You will need to create or reuse some sort of data entry for `editMember`

3. When making changes to members, either adding, editing, or deleting the table should reflect the changed data automatically

### Back end

1. Complete `AddMember`, `UpdateMember` and `DeleteMember` methods in `api/Controllers/MembersController`
    1. You're allowed to choose whatever http method, routes, and responses you feel appropriate for the different methods, and can change the existing methods as you wish (as long as the front end continues to work)
2. Complete `AddMember`, `UpdateMember` and `DeleteMember` methods in `api/DB/MembersRepository`

## Grading

- 65% of your mark will be based on correctness, i.e. the code runs, all tests pass, the frontend works
- The remaining 35% will be based on subjective measueres, such as code quality, efficiency, or front end UI/UX

## Notes

- All areas where we expect code to be completed have a comment of `TODO` on them. Use this to ensure you've completed everything
    - All frontend clients will have these comments, this does not mean you need to complete all three clients
- You may take as much time as you feel is appropriate to complete the test
- You should make regular commits to the repository so we can see your progress when we grade
- Copying code from the web is allowed as long as you don't copy everything and source what you do copy
- If you aren't able to complete something that is OK, leave in your attempts, and attempt to explain why you couldn't solve it
- If you have an idea for improvements or extras that you would like to do, write them down somewhere, and it will be considered.
- When you submit let us know which frontend framework you've decided to use, anything you were unable to complete, and how long you spent on the test. We'd also appreciate any feedback you have for us about the test (too easy/hard, confusing instructions, difficult to set up)
- If you want to restore the DB the creation script is in `api/DB/db_init.sql`

## To run

Frontend:

- Angular
    ```bash
    cd angular-client/ && npm start
    ```

- React
    ```bash
    cd react-client/ && npm start
    ```

- Vue
    ```bash
    cd vue-client/ && npm start
    ```

Backend:

```bash
cd api/ && dotnet run
```