# Getting Started with Create React App

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## How to start the project alongside the reporting service

1. Install the node dependencies - **npm install**

2. Execute the "prepare-service" script to build to reporting service project - **npm run prepare-service**

3. Execute the "start" script which will run the reporting service backend and the react frontend - **npm run start**

## MSB1060

If you run into the error `MSB1060: Undefined environment variable passed in as switch`, install the latest stable NodeJS version.

https://nodejs.org/en/ 

## Available Scripts

In the project directory, you can run:

### `npm run start`

This will execute the `npm run run-service` and `npm run start-react` script to start both the backend and the frontend.

### `npm run prepare-service`

This will build the Reporting REST Service with CORS demo that this project connects to.

### `npm run run-service`

This will run the Reporting REST Service with CORS demo that this project connects to.

### `npm start-react`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.\
You will also see any lint errors in the console.
