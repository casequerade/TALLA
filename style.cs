body {
  font-family: sans-serif;
  margin: 0;
  background: #fff;
  color: #222;
}

.profile {
  display: flex;
  gap: 16px;
  padding: 20px;
  align-items: center;
}

.profile-pic {
  width: 80px;
  height: 80px;
  border-radius: 50%;
  object-fit: cover;
}

.grid {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 4px;
  padding: 10px;
}

.grid img {
  width: 100%;
  display: block;
  object-fit: cover;
}

