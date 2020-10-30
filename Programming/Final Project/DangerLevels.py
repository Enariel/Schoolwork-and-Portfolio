#A struct class to create each Danger Level for use in tables
class DangerLevel(object):
    #Variables to be used by the table.
    def __init__(self, Level, Name, Desc):
        self.Level = Level
        self.Name = Name
        self.Desc = Desc
    #Formatting for data output
    def __repr__(self):
        return "DangerLevel('{}', '{}', '{}')".format(self.DangerLevel, self.Level, self.Name, self.Desc)