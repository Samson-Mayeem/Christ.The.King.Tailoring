package dbConfig

import (
	"github.com/jinzhu/gorm"
	_ "github.com/jinzhu/gorm/dialects/mysql"
	"runtime/trace"
)
import _ "GOPRO/models"

var DB *gorm.DB

func ConnectDatabase() {
	database, err := gorm.Open("mysql", "root:123456@tcp(127.0.0.1:3306)/task_management")

	if err != nil {
		panic("Failed to connect to database!")
	}

	database.AutoMigrate(&trace.Task{})

	DB = database
}
