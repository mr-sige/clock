from datetime import datetime

today = datetime.now().strftime("%B %d, %Y")
time = datetime.now().time().strftime("%H:%M")

print(today, time)