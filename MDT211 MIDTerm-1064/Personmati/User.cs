class User {
    private string userName;
    private string password;
    

    public User(string userName, string password) {
        this.userName = userName;
        this.password = password;
        
    }

    public string GetUserName() {
        return this.userName;
    }

    public string GetPassword() {
        return this.password;
    }

}