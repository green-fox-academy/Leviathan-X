SELECT reviewer.name, movie.title, rating.stars, rating.ratingDate FROM rating
JOIN reviewer ON reviewer.rID = rating.rID
JOIN movie ON movie.mID = rating.mID
ORDER BY reviewer.name ASC, movie.title ASC, rating.stars ASC;