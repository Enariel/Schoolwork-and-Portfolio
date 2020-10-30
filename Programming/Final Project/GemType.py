#A struct class to create each GemType for use in tables
class GemType(object):
    #Variables to be used by the table.
    def __init__(self, ID, Name, Desc):
        self.ID = ID
        self.Name = Name
        self.Desc = Desc
    #Formatting for data output
    def __repr__(self):
        return "GemType('{}', '{}', '{}')".format(self.ID, self.Name, self.Desc)
