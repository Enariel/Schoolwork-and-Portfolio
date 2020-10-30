
def myRange(stop = int, step = None, start = None, ):
    

    if start == None and step == None:
        start = 0
        step = 1
    elif start == None:
        start = 0
    elif step == None:
        step = 1
    else:
        start = int(start)
        step = int(step)


    rangeList = []

    while True:
        if start < stop:
            rangeList.append(start)
            start += step
        else:
            break

    return rangeList