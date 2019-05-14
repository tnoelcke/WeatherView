#!/bin/python

class DataField:
    name=""
    data = []


    def __init__(self, name, data):
        self.name = name
        self.data = data

    def getName(self):
        return self.name
    
    def getData(self):
        return self.data

    def printData(self):
        print(self.data)
    
    def printName(self):
        print(self.name)
    