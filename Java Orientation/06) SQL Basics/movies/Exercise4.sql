SELECT name FROM reviewer
JOIN rating ON reviewer.rID = rating.rID
WHERE ratingDate IS null;