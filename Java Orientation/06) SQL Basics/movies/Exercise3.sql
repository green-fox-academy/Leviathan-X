SELECT title FROM movie
LEFT JOIN rating ON movie.mID = rating.mID
WHERE stars IS null;