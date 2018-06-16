# Data Maintainer

## Setup

## Running server

## Description

Given that the data changes often and not at predicable intervals I will also have a data maintainer service that will independently check and update the data if there is more up to date data. This will also be a flask API. Essentially, the API will make requests to this api to check that the data is up to date. If it is not than the maintainer will send the data is currently has along with a note that more up to date info will be available shortly. It will then download the data and replace the current out of date data. This is likely to be the largest technical challenge on this project.