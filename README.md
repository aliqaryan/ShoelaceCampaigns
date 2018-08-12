# ShoelaceCampaigns
● We’re most interested in your approach modelling this application
>	On Backend: I designed and implemented these classes:

Models:
1)	Template: represents template including required properties and methods.

2)	Campaign: represents campaign object including required properties and method. It also has dependency to template object. 

3)	UserProduct: represents user product object that we get from Shoelace resource endpoint and is used for custom values of the campaign to be created.

Services: 

1)	Services class that is used to invoke service endpoints like getUserProducts() and getTemplatesInfo()


>	On Frontend:

1)	ViewModels: 

We have two view models, HomeViewModel to provide info for the homepage (Create Campaign page) and CampaignViewModel to pass required parameters from the mentioned page to Save Campaign method (after clicking Save& Publish)


● Submit the code via link to the version control system of your choice

I Used Git under VSTS.


● Make sure you include instructions on how to run your app

1) After running the project, it goes to the first page that is “Create Campaign” page. User can pick available Templates from the dropdown and it will populate other fields accordingly. For “Ad Title” and “Ad Copy” there is another way to customize the value by picking any of “User Products” list displayed on the dropdown above those fields.

2) Ad Title, Ad Copy and Image, can have multiple values, but to enter more than one value, they should be separated by comma.

3) Other fields can be edited by user. 

4) Finally by clicking on ”Save & Publish” it will save the Campaign into a file on local machine (In Json format at c:\logs\campaign.json). I assumed it will be published to a social media like Facebook. An alert comes up with a message showing process completed successfully.  


● Use any language, any IDE, or any framework you are comfortable with

I used Visual studio 2017 and ASP.Net Core 2, C#, JavaScript and JQuery


● Record all your assumptions. It is ok to make reasonable assumptions during implementations, as long as the main objective is accomplished.

1) Save & Publish is occurring on one call and at the same time after click on save button.

2) There is no real publishing for the campaign and my assumption is that by saving the campaign it will be published (it wasn’t clear in the assessment).

3) Fields like Ad Title, Ad Copy and Image, can have multiple values, but to enter more than one value, they should be separated by comma.

● Optional feature is really optional! Make sure to focus on the main objective first.

Optional step is done with UI (as a single web application)
