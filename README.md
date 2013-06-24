# Proof of Concept: AppHarbor

MVC4 web app deployed and running on AppHarbor.  Uses SQL Server for database and Simple Membership for authentication.


URL:	  http://test1-146.apphb.com

Login:    guest

Password: guest123456


References:

[*AppHarbor Deploying your first application using Git*](http://support.appharbor.com/kb/getting-started/deploying-your-first-application-using-git)

[*Announcing GitHub support*](http://blog.appharbor.com/2011/10/13/announcing-github-support)

[*Deploy to AppHarbor using GitHub for Windows*](http://blog.appharbor.com/2012/05/25/deploy-to-appharbor-using-github-for-windows)

[*Using Sequelizer*](http://support.appharbor.com/kb/add-ons/using-sequelizer)

[*Connection String Error*]http://support.appharbor.com/discussions/problems/6400-the-aspnet-simple-membership-database-could-not-be-initialized

Also change connection string in Filters/InitializeSimpleMembershipAttribute.cs, line 41
