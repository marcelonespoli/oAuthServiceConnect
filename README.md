# oAuthServiceConnect
Connect using the oAuth service to Facebook without using that provider’s SDK.

In order to test this applicaiton you need a Meta for Developers account in https://developers.facebook.com

![image](https://github.com/marcelonespoli/oAuthServiceConnect/assets/23698989/e73cb02c-7d32-47b3-a1b5-c4bfdef58d23)

After having your Meta Developer account setup, you need add an App.

![image](https://github.com/marcelonespoli/oAuthServiceConnect/assets/23698989/3d74759d-dc7a-4045-a8de-2ffe67d37d16)

Add the Redirects URIs in your Client OAuth settings
![image](https://github.com/marcelonespoli/oAuthServiceConnect/assets/23698989/d5cd327e-899a-4815-a52b-00c30be07b33)

Add your App ID and App secret in the appsetting of the API

![image](https://github.com/marcelonespoli/oAuthServiceConnect/assets/23698989/25a0f9f3-d23a-4121-917f-c91cee7a9eac)


# Running the Application

Starting the API the endpoint https://localhost:5003/api/facebook will be called.

![image](https://github.com/marcelonespoli/oAuthServiceConnect/assets/23698989/7f6f32d0-d889-4ee1-a463-ac6853b977e4)

The Facebook login page will be showed. Add your login and password.

![image](https://github.com/marcelonespoli/oAuthServiceConnect/assets/23698989/64951a08-a8ab-494d-a83d-2c9b90b40844)

After a successful login the user data is returned on the screen.

![image](https://github.com/marcelonespoli/oAuthServiceConnect/assets/23698989/84bd1879-f4fb-4582-9c4c-5e3b509b5231)
