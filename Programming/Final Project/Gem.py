#A struct class to create each GemType for use in tables
class Gem(object):
    #Variables to be used by the table.
    def __init__(self, GemType, ID, Name):
        self.GemTypeID = GemType
        self.ID = ID
        self.Name = Name
    #Formatting for data output
    def __repr__(self):
        return "GemType('{}', '{}', '{}')".format(self.GemTypeID, self.ID, self.Name)
